using CPUFrameWork;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select s.UserName, ct.CuisineTypeDesc, r.* from Recipe r join Staff s on r.StaffId = s.StaffId join CuisineType ct on r.CuisineTypeId = ct.cuisineTypeId where r.RecipeId = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtUserName.DataBindings.Add("Text", dt, "UserName");
            txtCuisineType.DataBindings.Add("Text", dt, "CuisineTypeDesc");
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtCalories.DataBindings.Add("Text", dt, "Calories"); 
            txtDateCreated.DataBindings.Add("Text", dt, "DateCreated"); 
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtRecipePicture.DataBindings.Add("Text", dt, "RecipePicture");
            this.Show();
        }
    }
}
