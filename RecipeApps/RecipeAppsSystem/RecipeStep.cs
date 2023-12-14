using System.Data.SqlClient;
namespace RecipeAppsSystem
{
    public class RecipeStep
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeStepGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach(DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
            }

            SQLUtility.SaveDataTable(dt, "RecipeStepUpdate");
        }

        public static void Delete(int recipestepid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeStepDelete");
            cmd.Parameters["@RecipeStepId"].Value = recipestepid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
