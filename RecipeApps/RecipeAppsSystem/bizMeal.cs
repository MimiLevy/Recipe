using CPUFramework;

namespace RecipeAppsSystem
{
    public class bizMeal : bizObject<bizMeal>
    {
        public bizMeal() { }

        private int _mealid;
        private int _staffid;
        private string _mealname;
        private string _mealdescription;
        private string _user;
        private DateTime _datedrafted;
        private int _mealactive;
        private string _mealpicture;
        private int _calories;
        private int _numcourses;
        private int _numrecipes;

        public int MealId
        {
            get { return _mealid; }
            set
            {
                if (_mealid != value)
                {
                    _mealid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int StaffId
        {
            get { return _staffid; }
            set
            {
                if(_staffid != value)
                {
                    _staffid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MealName
        {
            get { return _mealname; }
            set
            {
                if (_mealname != value)
                {
                    _mealname = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string MealDescription
        {
            get { return _mealdescription; }
            set
            {
                if (_mealdescription != value)
                {
                    _mealdescription = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string User
        {
            get { return _user; }
            set
            {
                if (_user != value)
                {
                    _user = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DtaeDrafted
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


        public int MealActive
        {
            get { return _mealactive; }
            set
            {
                if (_mealactive != value)
                {
                    _mealactive = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MealPicture
        {
            get { return _mealpicture; }
            set
            {
                if (_mealpicture != value)
                {
                    _mealpicture = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int Calories
        {
            get { return _calories; }
            set
            {
                if(_calories != value)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumCourses
        {
            get { return _numcourses; }
            set
            {
                if (_numcourses != value)
                {
                    _numcourses = value;
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
    }
}
