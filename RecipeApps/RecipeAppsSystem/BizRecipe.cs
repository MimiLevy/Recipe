using CPUFramework;

namespace RecipeAppsSystem
{
    public class BizRecipe : BizObject

    {
        public BizRecipe()
        {

        }
        private int _recipeid;
        private int _staffid;
        private int _cuisinetypeid;
        private string _recipename = "";
        private int _calories;
        private DateTime? _datedrafted;
        private DateTime? _datepublished;
        private DateTime? _datearchived;

    // I'm not sure if I'm meant to include the computed columns.
        private string _recipestatus = "";
        private string _recipepicture = "";

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
      
    }
}
