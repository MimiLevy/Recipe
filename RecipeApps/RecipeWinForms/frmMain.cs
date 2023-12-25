namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuDashboard.Click += Mnu_Click;
            mnuRecipeList.Click += Mnu_Click;
            mnuRecipeInformation.Click += Mnu_Click;
            mnuCloneRecipe.Click += Mnu_Click;
            mnuMealList.Click += Mnu_Click;
            mnuCookbookList.Click += Mnu_Click;
            mnuCookbookInformation.Click += Mnu_Click;
            mnuAutoCreateCookbook.Click += Mnu_Click;
            mnuDataMaintenance.Click += Mnu_Click;
            mnuWindowsTile.Click += MnuWindowsTile_Click;
            mnuWindowsCascade.Click += MnuWindowsCascade_Click;
            this.Shown += FrmMain_Shown;
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            frmLogin f = new();
            bool b = f.ShowLogin();
            if(b == false)
            {
                this.Close();
                Application.Exit();
                return;
            }
            OpenForm(typeof(frmDashboard));
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype, pkvalue);
            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmRecipeInformation))
                {
                    frmRecipeInformation f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmChangeRecipeStatus))
                {
                    frmChangeRecipeStatus f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmCookbookInformation))
                {
                    frmCookbookInformation f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else
                {
                    newfrm = (Form)Activator.CreateInstance(frmtype);
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Newform_FormClosed;
                    newfrm.TextChanged += Newform_TextChanged;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetupNav(tsMain);
            }
        }

        private void Newform_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Newform_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Mnu_Click(object? sender, EventArgs e)
        {
            Type? t = null;
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            switch (btn.Name)
            {
                case "mnuDashboard":
                    t = typeof(frmDashboard);
                    break;
                case "mnuRecipeList":
                    t = typeof(frmRecipeList);
                    break;
                case "mnuRecipeInformation":
                    t = typeof(frmRecipeInformation);
                    break;
                case "mnuCloneRecipe":
                    t = typeof(frmCloneRecipe);
                    break;
                case "mnuMealList":
                    t = typeof(frmMealList);
                    break;
                case "mnuCookbookList":
                    t = typeof(frmCookbookList);
                    break;
                case "mnuCookbookInformation":
                    t = typeof(frmCookbookInformation);
                    break;
                case "mnuAutoCreateCookbook":
                    t = typeof(frmAutoCreateCookbook);
                    break;
                case "mnuDataMaintenance":
                    t = typeof(frmDataMaintenance);
                    break;

            }
            OpenForm(t);
        }

        private void MnuWindowsCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuWindowsTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
