﻿namespace RecipeWinForms
{
    //AF If autocreating the cookbook fails, it still shows a popup that cookbook was created (for example, I tried to create a coobook twice for the 
    //same user, so it said cookbook name must be unique, but then still showed that popup after
    public partial class frmAutoCreateCookbook : Form
    {
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            this.Activated += FrmAutoCreateCookbook_Activated;
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void FrmAutoCreateCookbook_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstUserName, DataMaintenance.GetDataList("Staff", true), null, "Staff");
        }

        private void AutoCreateCookbook()
        {
            var msg = "Please choose user for new cookbook!";
            int staffid = WindowsFormsUtility.GetIdFromComboBox(lstUserName);
            if (staffid > 0)
            {
                msg = "New Cookbook was created!";
                Application.UseWaitCursor = true;
                try
                {
                    Cookbook.AutoCreateCookbook(staffid);
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }
            }
            MessageBox.Show(msg, Application.ProductName);
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            AutoCreateCookbook();
        }
    }
}