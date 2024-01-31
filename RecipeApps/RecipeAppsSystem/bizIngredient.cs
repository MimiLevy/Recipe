using CPUFramework;
using System.Data.SqlClient;

namespace RecipeAppsSystem
{
    public class bizIngredient:BizObject<bizIngredient>
    {
        private int _ingredientid;
        private string _ingredientname = "";
        private string _ingredientpicture = "";

        public List<bizIngredient> Search(string ingredientnameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "IngredientName", ingredientnameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
        public int IngredientId
        {
            get => _ingredientid;
            set
            {
                if(_ingredientid != value)
                {
                    _ingredientid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string IngredientName
        {
            get => _ingredientname;
            set
            {
                if(_ingredientname != value)
                {
                    _ingredientname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string IngredientPicture
        {
            get => _ingredientpicture;
            set
            {
                if(_ingredientpicture != value)
                {
                    _ingredientpicture = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
