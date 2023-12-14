using System.Data.SqlClient;

namespace RecipeAppsSystem
{
    public class Meal
    {
        public static DataTable GetList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
    }
}
