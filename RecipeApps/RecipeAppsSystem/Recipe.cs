using System.Data;

namespace RecipeAppsSystem
{
    public class Recipe
    {
        public static DataTable SearchForRecipes(string recipename)
        {
            string sql = "select r.RecipeId, r.RecipeName from Recipe r where r.recipename like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select s.UserName, ct.CuisineTypeDesc, r.* from Recipe r join Staff s on r.StaffId = s.StaffId join CuisineType ct on r.CuisineTypeId = ct.cuisineTypeId where r.RecipeId = " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetList(string tablename)
        {
            return SQLUtility.GetDataTable("select * from " + tablename);
        }
         public static void Save(DataTable dtRecipe)
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
                    $"where RecipeId = '{r["RecipeId"]}'"
                    );
            }
            else
            {
                sql = "insert Recipe(StaffId, CuisineTypeId, RecipeName, Calories, DateCreated)";
                sql += $"select '{r["StaffId"]}', '{r["CuisineTypeId"]}', '{r["RecipeName"]}', '{r["Calories"]}', '{r["DateCreated"]}'";
            }

            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtRecipe)
        {
            int recipeid = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + recipeid;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
