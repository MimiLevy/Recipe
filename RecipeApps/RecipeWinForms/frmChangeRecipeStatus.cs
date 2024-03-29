﻿using CPUFrameWork;
using System.Data;

namespace RecipeWinForms
{
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
                    txtbox.Text = dt.ToString();
                }
            }
            try
            {
                DateTime? datedrafted = string.IsNullOrEmpty(txtDateDrafted.Text) ? null : DateTime.Parse(txtDateDrafted.Text);
                DateTime? datepublished = string.IsNullOrEmpty(txtDatePublished.Text) ? null : DateTime.Parse(txtDatePublished.Text);
                DateTime? datearchived = string.IsNullOrEmpty(txtDateArchived.Text) ? null : DateTime.Parse(txtDateArchived.Text);

                Recipe.ChangeRecipeStatus(recipeid, datedrafted, datepublished, datearchived);

                LoadRecipeInformation();
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeInformation), recipeid);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
                lblDateDrafted.Text = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "DateDrafted").ToString();
                lblDatePublished.Text = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "DatePublished").ToString();
                lblDateArchived.Text = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "DateArchived").ToString();
            }
        }


        public void LoadRecipeInformation()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmRecipeInformation)
                {
                    ((frmRecipeInformation)f).bindsource.DataSource = Recipe.Load(recipeid);
                }
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
