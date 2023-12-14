using System.Data;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            this.Activated += FrmCookbookList_Activated;
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gDataCookbooks.CellDoubleClick += GDataCookbooks_CellDoubleClick;
            gDataCookbooks.KeyDown += GDataCookbooks_KeyDown;
        }
        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dt = Cookbook.GetList("Cookbook");
            foreach (DataColumn ch in dt.Columns)
            {
                ch.ColumnName = ch.ColumnName.EndsWith("Id") ? ch.ColumnName : WindowsFormsUtility.FormatGridHeaders(ch.ColumnName);
            }
            gDataCookbooks.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gDataCookbooks, "Cookbook");
            gDataCookbooks.Columns["Cookbook Active"].Visible = false;
            gDataCookbooks.Columns["Date Drafted"].Visible = false;
        }
        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gDataCookbooks, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookInformation), id);
            }
        }
        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }
        private void GDataCookbooks_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }
        private void GDataCookbooks_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gDataCookbooks.Rows.Count > 0)
            {
                ShowCookbookForm(gDataCookbooks.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }
    }
}
