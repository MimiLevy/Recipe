using System.Data.SqlClient;

namespace RecipeAppsSystem
{
    public class Cookbook
    {
        public static DataTable Load(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetList(string tablename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call Cookbook Save method becuase there are no rows in the table.");
            }
            DataRow r = dtcookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
        }
        public static void Delete(DataTable dtcookbook)
        {
            int cookbookid = (int)dtcookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void AutoCreateCookbook (int staffid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("AutoCreateCookbook");
            SQLUtility.SetParamValue(cmd, "@StaffId", staffid);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
