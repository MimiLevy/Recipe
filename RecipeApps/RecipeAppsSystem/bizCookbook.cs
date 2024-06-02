using CPUFramework;

namespace RecipeAppsSystem
{
    public class bizCookbook : bizObject<bizCookbook>
    {
        public bizCookbook() { }

        private int _cookbookid;
        private int _staffid;
        private string _cookbookname = "";
        private string _author = "";
        private decimal _price;
        private int _numrecipes;
        private DateTime _datedrafted;
        private string _cookbookskilllevel;
        private int _cookbookactive;
        private string _cookbookpicture = "";

        public int CookbookId
        {
            get { return _cookbookid; }
            set
            {
                if (_cookbookid != value)
                {
                    _cookbookid = value;
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

        public string CookbookName
        {
            get { return _cookbookname; }
            set
            {
                if (_cookbookname != value)
                {
                    _cookbookname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (_author != value)
                {
                    _author = value;
                    InvokePropertyChanged();
                }
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int NumRecipes
        {
            get { return _numrecipes; }
            set
            {
                if (_numrecipes != value)
                {
                    _numrecipes = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateDrafted
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

        public string CookbookSkillLevel
        {
            get { return _cookbookskilllevel; }
            set
            {
                if (_cookbookskilllevel != value)
                {
                    _cookbookskilllevel = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int CookbookActive
        {
            get { return _cookbookactive; }
            set
            {
                if (_cookbookactive != value)
                {
                    _cookbookactive = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string CookbookPicture
        {
            get { return _cookbookpicture; }
            set
            {
                if (_cookbookpicture != value)
                {
                    _cookbookpicture = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
