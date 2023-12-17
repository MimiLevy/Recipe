using CPUFrameWork;
using System.Data;

//AF If I try to save a cookbook without a user filled in, it shows a strange message that it cannot delete staff, it should just show a message that staff cannot be blank

namespace RecipeWinForms
{

    public partial class frmCookbookInformation : Form
    {
        DataTable dtcookbook = new();
        DataTable dtcookbookrecipe = new();
        BindingSource bindsource = new();
        string deletecolname = "deletecol";
        int cookbookid = 0;
        public frmCookbookInformation()
        {
            InitializeComponent();
            btnSaveCookbook.Click += BtnSaveCookbook_Click;
            btnDeleteCookbook.Click += BtnDeleteCookbook_Click;
            btnSaveRecipes.Click += BtnSaveRecipes_Click;
            gDataCookbookRecipes.CellContentClick += GDataCookbookRecipes_CellContentClick;
            this.FormClosing += FrmCookbookInformation_FormClosing;
            this.Shown += FrmCookbookInformation_Shown;
        }

       

        public void LoadForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Cookbook.Load(cookbookid);
            bindsource.DataSource = dtcookbook;

            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            DataTable dtusername = Cookbook.GetList("Staff");
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetListBinding(lstUserName, dtusername, dtcookbook, "Staff");
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(chkCookbookActive, bindsource);
            this.Text = GetCookbookDesc();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadCookbookRecipe()
        {
            dtcookbookrecipe = CookbookRecipe.LoadByCookbookId(cookbookid);
            gDataCookbookRecipes.Columns.Clear();
            gDataCookbookRecipes.DataSource = dtcookbookrecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gDataCookbookRecipes, Cookbook.GetList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.FormatGridForEdit(gDataCookbookRecipes, "CookbookRecipe");
            WindowsFormsUtility.AddDeleteButtonToGrid(gDataCookbookRecipes, deletecolname);
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
                this.Tag = cookbookid;
                dtcookbook = Cookbook.Load(cookbookid);
                bindsource.DataSource = dtcookbook;
               
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetCookbookDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Cookbook?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
               Application.UseWaitCursor = false;
            }
        }

        private void SaveCookbookRecipes()
        {
            try
            {
                CookbookRecipe.SaveTable(dtcookbookrecipe, cookbookid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteCookbookRecipe(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gDataCookbookRecipes, rowindex, "CookbookRecipeId");
            if(id > 0)
            {
                try
                {
                    CookbookRecipe.Delete(id);
                    LoadCookbookRecipe();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if(id > gDataCookbookRecipes.Rows.Count)
            {
                gDataCookbookRecipes.Rows.RemoveAt(rowindex);
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDeleteCookbook.Enabled = b;
            btnSaveRecipes.Enabled = b;
        }
        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }
        private void FrmCookbookInformation_Shown(object? sender, EventArgs e)
        {
            LoadCookbookRecipe();
        }
        private void BtnSaveCookbook_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnDeleteCookbook_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void BtnSaveRecipes_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipes();
        }
        private void GDataCookbookRecipes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteCookbookRecipe(e.RowIndex);
        }
        private void FrmCookbookInformation_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook))
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (response)
                {
                    case DialogResult.Yes:
                        if (Save() == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
    }
}
