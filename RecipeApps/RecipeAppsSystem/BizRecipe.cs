using CPUFramework;
using System.Data.SqlClient;

namespace RecipeAppsSystem
{
    public class BizRecipe : bizObject<BizRecipe>

    {
        public BizRecipe()
        {

        }
        private int _recipeid;
        private int _staffid;
        private int _cuisinetypeid;
        private string _recipename = "";
        private string _user = "";
        private int _calories;
        private int _vegan;
        private DateTime? _datedrafted;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private int _numingredients;

        private string _recipestatus = "";
        private string _recipepicture = "";

        public List<BizRecipe> Search(string recipenameval, string cookbooknameval = "")
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "@RecipeName", recipenameval);
            SQLUtility.SetParamValue(cmd, "@CookbookName", cookbooknameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
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
        public int StaffId
        {
            get { return _staffid; }
            set
            {
                if (_staffid != value)
                {
                    _staffid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int CuisineTypeId
        {
            get { return _cuisinetypeid; }
            set
            {
                if (_cuisinetypeid != value)
                {
                    _cuisinetypeid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string RecipeName
        {
            get { return _recipename; }
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string User
        {
            get { return _user; }
            set
            {
                if(_user != value)
                {
                    _user = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int Calories
        {
            get { return _calories; }
            set
            {
                if (_calories != value)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int Vegan
        {
            get { return _vegan; }
            set
            {
                if (_vegan != value)
                {
                    _vegan = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime? DateDrafted
        {
            get { return _datedrafted; }
            set
            {
                if (_datedrafted != value)
                {
                    _datedrafted = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime? DatePublished
        {
            get { return _datepublished; }
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime? DateArchived
        {
            get { return _datearchived; }
            set
            {
                if (_datearchived != value)
                {
                    _datearchived = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string RecipeStatus
        {
            get { return _recipestatus; }
            set
            {
                if (_recipestatus != value)
                {
                    _recipestatus = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string RecipePicture
        {
            get { return _recipepicture; }
            set
            {
                if (_recipepicture != value)
                {
                    _recipepicture = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumIngredients
        {
            get { return _numingredients; }
            set
            {
                if(_numingredients != value)
                {
                    _numingredients = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
