using System.Data.SqlClient;

namespace RecipeAppsSystem
{
    public class Recipe
    {
        public static DataTable SearchForRecipes(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            if (recipename == "")
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
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }


        public static DataTable GetList(string tablename, bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void Save(DataTable dtRecipe)
        {
            if (dtRecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call Recipe Save method becuase there are no rows in the table.");
            }
            DataRow r = dtRecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void Delete(DataTable dtRecipe)
        {
            int recipeid = (int)dtRecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static int CloneRecipe(int basedrecipeid)
        {
            int newid = 0;
            SqlCommand cmd = SQLUtility.GetSqlCommand("CloneRecipe");
            SQLUtility.SetParamValue(cmd, "@BasedRecipeId", basedrecipeid);
            SQLUtility.ExecuteSQL(cmd);
            newid = (int)cmd.Parameters["@RecipeId"].Value;
            return newid;
        }

        public static void ChangeRecipeStatus(int recipeid, DateTime? datedrafted, DateTime? datepublished, DateTime? datearchived)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeUpdate");
            SQLUtility.SetParamValue(cmd, "@UpdateOnlyStatus", 1);
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            cmd.Parameters["@DateDrafted"].Value = datedrafted;
            cmd.Parameters["@DatePublished"].Value = datepublished;
            cmd.Parameters["@DateArchived"].Value = datearchived;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
