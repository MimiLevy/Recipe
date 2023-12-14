using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            this.Activated += FrmRecipeList_Activated;
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gDataRecipes.CellDoubleClick += GDataRecipes_CellDoubleClick;
            gDataRecipes.KeyDown += GDataRecipes_KeyDown;
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dt = Recipe.GetList("Recipe");

            foreach (DataColumn ch in dt.Columns)
            {
                ch.ColumnName = ch.ColumnName.EndsWith("Id") ? ch.ColumnName : WindowsFormsUtility.FormatGridHeaders(ch.ColumnName);
            }
            gDataRecipes.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gDataRecipes, "Recipe");
            foreach (DataGridViewColumn col in gDataRecipes.Columns)
            {
                if (col.Name.StartsWith("Date"))
                {
                    col.Visible = false;
                }
            }
            gDataRecipes.Columns["List Order"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gDataRecipes, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeInformation), id);
            }
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
        private void GDataRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void GDataRecipes_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gDataRecipes.SelectedRows.Count > 0)
            {
                ShowRecipeForm(gDataRecipes.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

    }
}
