using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtRecipe;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click; 
            btnDelete.Click += BtnDelete_Click;
        }

        

        public void ShowForm(int recipeid)
        {
            dtRecipe = Recipe.Load(recipeid);

            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtUserName = Recipe.GetList("Staff");
            DataTable dtCuisineType = Recipe.GetList("CuisineType");
            WindowsFormsUtility.SetLIstBinding(lstUserName,dtUserName, dtRecipe, "Staff");
            WindowsFormsUtility.SetLIstBinding(lstCuisineTypeDesc, dtCuisineType, dtRecipe, "CuisineType");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipePicture, dtRecipe);
            this.Show();

        }

        private void Save()
        {
            Recipe.Save(dtRecipe);
            this.Close();
        }
        private void Delete()
        {
            Recipe.Delete(dtRecipe);
            this.Close();
        }
       
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
