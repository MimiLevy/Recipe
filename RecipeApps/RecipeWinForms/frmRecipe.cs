using CPUFrameWork;
using System.Data;
using CPUWindowsFormsFrameWork;
using System.Diagnostics;
using System.Configuration.Internal;

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
            string sql = "select s.UserName, ct.CuisineTypeDesc, r.* from Recipe r join Staff s on r.StaffId = s.StaffId join CuisineType ct on r.CuisineTypeId = ct.cuisineTypeId where r.RecipeId = " + recipeid.ToString();
            dtRecipe = SQLUtility.GetDataTable(sql);

            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtUserName = SQLUtility.GetDataTable("select * from Staff");
            DataTable dtCuisineType = SQLUtility.GetDataTable("select * from CuisineType");
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
            SQLUtility.DebugPrintDataTable(dtRecipe);
            DataRow r = dtRecipe.Rows[0];
            int recipeid = (int)r["RecipeId"];
            string sql = "";

            if (recipeid > 0)
            {
                sql = String.Join(Environment.NewLine, $"update Recipe set",
                    $"StaffId = '{r["StaffId"]}',", 
                    $"CuisineTypeId = '{r["CuisineTypeId"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateCreated = '{r["DateCreated"]}'",
                    //$"DatePublished = '{r["DatePublished"]}',",
                    //$"DateArchived = '{r["DateArchived"]}'",
                    $"where RecipeId = '{r["RecipeId"]}'"
                    );
            }
            else
            {
                sql = "insert Recipe(StaffId, CuisineTypeId, RecipeName, Calories, DateCreated)";
                sql += $"select '{r["StaffId"]}', '{r["CuisineTypeId"]}', '{r["RecipeName"]}', '{r["Calories"]}', '{r["DateCreated"]}'";
            }

            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }
        private void Delete()
        {
            int recipeid = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + recipeid;
            SQLUtility.ExecuteSQL(sql);
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
