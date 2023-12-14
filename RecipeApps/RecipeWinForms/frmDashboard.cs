using System.Data;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click; 
            btnCookbookList.Click += BtnCookbookList_Click;
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dt = Dashboard.GetDashBoard();
            gData.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gData, "Recipe");
        }

        private void ShowForm(Type frmtype)
        {
            if(this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(frmtype);
            }
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmCookbookList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmMealList));
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmRecipeList));
        }

    }
}
