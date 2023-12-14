using System.Data;

namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            this.Activated += FrmMealList_Activated;
        }

        private void FrmMealList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dt = Meal.GetList();
            foreach (DataColumn ch in dt.Columns)
            {
                ch.ColumnName = ch.ColumnName.EndsWith("Id") ? ch.ColumnName : WindowsFormsUtility.FormatGridHeaders(ch.ColumnName);
            }
            gDataMeals.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gDataMeals, "Meal");
        }
    }
}
