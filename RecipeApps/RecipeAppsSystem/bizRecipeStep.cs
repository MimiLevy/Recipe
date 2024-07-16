using CPUFramework;
using System.Data.SqlClient;

namespace RecipeAppsSystem
{
    public class bizRecipeStep: bizObject<bizRecipeStep>
    {
        private int _recipestepid;
        private int _recipeid;
        private string _stepdesc = "";
        private int _sequence;
        
        public List<bizRecipeStep> LoadByRecipeId(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeStepGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            var dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
        public int RecipeSstepId
        {
            get { return _recipestepid; }
            set
            {
                if (_recipestepid != value)
                {
                    _recipestepid = value;
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
        public string StepDesc
        {
            get { return _stepdesc; }
            set
            {
                if (_stepdesc != value)
                {
                    _stepdesc = value;
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
