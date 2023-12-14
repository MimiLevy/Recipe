namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        public frmCloneRecipe()
        {
            InitializeComponent();
            this.Activated += FrmCloneRecipe_Activated;
            btnClone.Click += BtnClone_Click;
        }
        private void FrmCloneRecipe_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstRecipeName, Recipe.GetList("Recipe", true), null, "Recipe");
        }

        private void CloneRecipe()
        {
            int basedonrecipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
            Application.UseWaitCursor = true;
            try
            {
                int newid = 0;
                newid = Recipe.CloneRecipe(basedonrecipeid);
                if (newid > 0)
                {
                    if (this.MdiParent != null && this.MdiParent is frmMain)
                    {
                        ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeInformation), newid);
                        this.Close();
                    }
                }
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

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
        }
    }
}
