using CPUFramework;
using System.Data.SqlClient;

namespace RecipeAppsSystem
{
    public class bizRecipeIngredient: bizObject<bizRecipeIngredient>
    {
        private int _recipeingredientid;
        private int _recipeid;
        private decimal _amount;
        private int _ingredientid;
        private int _measurementtypeid;
        private string _ingredientname = "";
        private string _measurementtypedesc = "";
        private int _sequence;

        public List<bizRecipeIngredient> LoadByRecipeId(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            var dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int RecipeIngredientId
        {
            get { return _recipeingredientid; }
            set
            {
                if(_recipeingredientid != value)
                {
                    _recipeingredientid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int RecipeId
        {
            get { return _recipeid; }
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public decimal Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int IngredientId
        {
            get { return _ingredientid; }
            set
            {
                if (_ingredientid != value)
                {
                    _ingredientid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int MeasurementTypeId
        {
            get { return _measurementtypeid; }
            set
            {
                if (_measurementtypeid != value)
                {
                    _measurementtypeid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string IngredientName
        {
            get { return _ingredientname; }
            set
            {
                if (_ingredientname != value)
                {
                    _ingredientname = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string MeasurementTypeDesc
        {
            get { return _measurementtypedesc; }
            set
            {
                if (_measurementtypedesc != value)
                {
                    _measurementtypedesc = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int Sequence
        {
            get { return _sequence; }
            set
            {
                if (_sequence != value)
                {
                    _sequence = value;
                    InvokePropertyChanged();
                }
            }
        }


    }
}
