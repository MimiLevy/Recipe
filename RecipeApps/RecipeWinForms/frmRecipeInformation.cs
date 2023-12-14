using CPUFrameWork;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipeInformation : Form
    {
        DataTable dtrecipe = new();
        DataTable dtrecipeingredient = new();
        DataTable dtrecipestep = new();
        BindingSource bindsource = new();
        string deletecolname = "deletecol";
        int recipeid = 0;
        public frmRecipeInformation()
        {
            
            InitializeComponent();
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            btnDeleteRecipe.Click += BtnDeleteRecipe_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            gDataIngredients.CellContentClick += GDataIngredients_CellContentClick;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            gDataSteps.CellContentClick += GDataSteps_CellContentClick;
            this.FormClosing += FrmRecipeInformation_FormClosing;
            this.Shown += FrmRecipeInformation_Shown;
        }
        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtUserName = Recipe.GetList("Staff");
            DataTable dtCuisineType = Recipe.GetList("CuisineType");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetListBinding(lstUserName, dtUserName, dtrecipe, "Staff");
            WindowsFormsUtility.SetListBinding(lstCuisineTypeDesc, dtCuisineType, dtrecipe, "CuisineType");
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);

            this.Text = GetRecipeDesc();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadRecipeIngredients()
        {
            dtrecipeingredient = RecipeIngredient.LoadByRecipeId(recipeid);
            gDataIngredients.Columns.Clear();
            gDataIngredients.DataSource = dtrecipeingredient;
            WindowsFormsUtility.AddComboBoxToGrid(gDataIngredients, Recipe.GetList("MeasurementType"), "MeasurementType", "MeasurementTypeDesc");
            WindowsFormsUtility.AddComboBoxToGrid(gDataIngredients, Recipe.GetList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.FormatGridForEdit(gDataIngredients, "RecipeIngredient");
            WindowsFormsUtility.AddDeleteButtonToGrid(gDataIngredients, deletecolname);
            
            
        }

        private void LoadRecipeSteps()
        {
            dtrecipestep = RecipeStep.LoadByRecipeId(recipeid);
            gDataSteps.Columns.Clear();
            gDataSteps.DataSource = dtrecipestep;
            WindowsFormsUtility.AddDeleteButtonToGrid(gDataSteps, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gDataSteps, "RecipeStep");
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;

                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeDesc();
            }
            catch(Exception ex)
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
            var response = MessageBox.Show("Are you sure you want to delete this Recipe?", Application.ProductName, MessageBoxButtons.YesNo);
            if(response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }


        private void SaveRecipeIngredients()
        {
            try
            {
                RecipeIngredient.SaveTable(dtrecipeingredient, recipeid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void DeleteRecipeIngredient(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gDataIngredients, rowindex, "RecipeIngredientId");
            if(id > 0)
            {
                try
                {
                    RecipeIngredient.Delete(id);
                    LoadRecipeIngredients();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id <  gDataIngredients.Rows.Count)
            {
                gDataIngredients.Rows.RemoveAt(rowindex);
            }
        }
        private void SaveRecipeSteps()
        {
            try
            {
                RecipeStep.SaveTable(dtrecipestep, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void DeleteRecipeStep(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gDataSteps, rowindex, "RecipeStepId");
            if (id > 0)
            {
                try
                {
                    RecipeStep.Delete(id);
                    LoadRecipeSteps();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gDataSteps.Rows.Count)
            {
                gDataSteps.Rows.RemoveAt(rowindex);
            }
        }
        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDeleteRecipe.Enabled = b;
            btnChangeStatus.Enabled = b;
            btnSaveIngredients.Enabled = b;
            btnSaveSteps.Enabled = b;
        }
        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if(pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }
        private void FrmRecipeInformation_Shown(object? sender, EventArgs e)
        {
            LoadRecipeIngredients();
            LoadRecipeSteps();
        }
        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            Save();
        }
        
        private void BtnDeleteRecipe_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredients();
        }

        private void GDataIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeIngredient(e.RowIndex);
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeSteps();
        }
        private void GDataSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            {
                DeleteRecipeStep(e.RowIndex);
            }
        }

        private void FrmRecipeInformation_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe))
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (response)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if(b == false)
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
        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeRecipeStatus), recipeid);
            }
        }
    }
}
