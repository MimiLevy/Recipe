using System.Data;
using System.Data.SqlClient;

namespace RecipeAppsSystem
{
    public class Recipe
    {
        public static DataTable SearchForRecipes(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            if(recipename == "")
            {
                cmd.Parameters["@All"].Value = 1;
            }
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }


        public static DataTable GetList(string tablename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
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
