using CPUFrameWork;
using System.Data;

namespace RecipeWinForms
{
/*AF It's not working to change the status from archvied to drafted, published to drafted, archived to published
It would be nice if when you change the status, it would close that form and show the recipe form, with the updated status.  NOw, if  you change the status
and go back to the recipe form, it doesn't show the updated status.  You can reach out if you are not sure how to do that */
    public partial class frmChangeRecipeStatus : Form
    {
        DataTable dtrecipe = new();
        BindingSource bindsource = new();

        int recipeid = 0;
        public frmChangeRecipeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
        }

        public void LoadForm(int recipeval)
        {
            recipeid = recipeval;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            this.Text = GetRecipeDesc() + " - Change Status";

            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);

            string currentstatus = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeStatus");
            SetButtonsEnabledBasedOnStatus(currentstatus);
        }

        private void ChangeStatus(string btnname)
        {
            var response = MessageBox.Show($"Are you sure you want to change this recipe to {btnname.Substring(3)}?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            foreach (TextBox txtbox in tblStatusDatesTxtBoxes.Controls)
            {
                if (txtbox.Name.Contains(btnname.Substring(3)))
                {
                    DateTime dt = DateTime.Now;
                    String date = dt.ToShortDateString();
                    txtbox.Text = date;
                    foreach (Button btn in tblButtons.Controls)
                    {
                        if (btn.Name == btnname)
                        {
                            btn.Enabled = false;
                        }
                    }
                }
            }
            try
            {
                DateTime? datedrafted = string.IsNullOrEmpty(txtDateDrafted.Text) ? null : DateTime.Parse(txtDateDrafted.Text);
                DateTime? datepublished = string.IsNullOrEmpty(txtDatePublished.Text) ? null : DateTime.Parse(txtDatePublished.Text);
                DateTime? datearchived = string.IsNullOrEmpty(txtDateArchived.Text) ? null : DateTime.Parse(txtDateArchived.Text);

                Recipe.ChangeRecipeStatus(recipeid, datedrafted, datepublished, datearchived);

                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
                lblDateDrafted.Text = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "DateDrafted").ToString();
                lblDatePublished.Text = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "DatePublished").ToString();
                lblDateArchived.Text = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "DateArchived").ToString();
            }
        }


        private void SetButtonsEnabledBasedOnStatus(string currentstatus)
        {
            foreach (Button btn in tblButtons.Controls)
            {
                if (currentstatus.Contains(btn.Text))
                {
                    btn.Enabled = false;
                }
            }
        }
        private string GetRecipeDesc()
        {
            string value = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            return value;
        }
        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            ChangeStatus(((Button)sender).Name);
        }
        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            ChangeStatus(((Button)sender).Name);
        }
        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            ChangeStatus(((Button)sender).Name);
        }
    }
}
