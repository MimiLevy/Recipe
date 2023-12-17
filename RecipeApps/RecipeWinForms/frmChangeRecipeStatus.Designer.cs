namespace RecipeWinForms
{
    partial class frmChangeRecipeStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            lblRecipeName = new Label();
            lblRecipeStatus = new Label();
            lblStatusDates = new Label();
            tblStatusDates = new TableLayoutPanel();
            tblStatusDatesTxtBoxes = new TableLayoutPanel();
            txtDateArchived = new TextBox();
            txtDatePublished = new TextBox();
            txtDateDrafted = new TextBox();
            tblStatusDatesLabels = new TableLayoutPanel();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            tblButtons = new TableLayoutPanel();
            btnDraft = new Button();
            btnArchive = new Button();
            btnPublish = new Button();
            tblMain.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tblStatusDatesTxtBoxes.SuspendLayout();
            tblStatusDatesLabels.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.87582F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.12418F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblRecipeStatus, 0, 1);
            tblMain.Controls.Add(lblStatusDates, 0, 2);
            tblMain.Controls.Add(tblStatusDates, 1, 2);
            tblMain.Controls.Add(tblButtons, 1, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 154F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(846, 562);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.BackColor = SystemColors.ControlLight;
            tblMain.SetColumnSpan(lblRecipeName, 3);
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(4, 14);
            lblRecipeName.Margin = new Padding(4, 14, 4, 14);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(838, 62);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.Anchor = AnchorStyles.Top;
            lblRecipeStatus.BackColor = SystemColors.ControlLight;
            tblMain.SetColumnSpan(lblRecipeStatus, 3);
            lblRecipeStatus.Location = new Point(133, 104);
            lblRecipeStatus.Margin = new Padding(4, 14, 4, 14);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(579, 44);
            lblRecipeStatus.TabIndex = 1;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Location = new Point(4, 202);
            lblStatusDates.Margin = new Padding(4, 40, 4, 0);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(162, 43);
            lblStatusDates.TabIndex = 2;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 1;
            tblMain.SetColumnSpan(tblStatusDates, 2);
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblStatusDates.Controls.Add(tblStatusDatesTxtBoxes, 0, 1);
            tblStatusDates.Controls.Add(tblStatusDatesLabels, 0, 0);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(196, 163);
            tblStatusDates.Margin = new Padding(3, 1, 3, 1);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.Size = new Size(647, 152);
            tblStatusDates.TabIndex = 3;
            // 
            // tblStatusDatesTxtBoxes
            // 
            tblStatusDatesTxtBoxes.ColumnCount = 3;
            tblStatusDatesTxtBoxes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatusDatesTxtBoxes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatusDatesTxtBoxes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatusDatesTxtBoxes.Controls.Add(txtDateArchived, 0, 0);
            tblStatusDatesTxtBoxes.Controls.Add(txtDatePublished, 0, 0);
            tblStatusDatesTxtBoxes.Controls.Add(txtDateDrafted, 0, 0);
            tblStatusDatesTxtBoxes.Dock = DockStyle.Fill;
            tblStatusDatesTxtBoxes.Location = new Point(3, 79);
            tblStatusDatesTxtBoxes.Name = "tblStatusDatesTxtBoxes";
            tblStatusDatesTxtBoxes.RowCount = 1;
            tblStatusDatesTxtBoxes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatusDatesTxtBoxes.Size = new Size(641, 70);
            tblStatusDatesTxtBoxes.TabIndex = 6;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(429, 10);
            txtDateArchived.Margin = new Padding(3, 10, 3, 3);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(209, 34);
            txtDateArchived.TabIndex = 2;
            txtDateArchived.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(216, 10);
            txtDatePublished.Margin = new Padding(3, 10, 3, 3);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(207, 34);
            txtDatePublished.TabIndex = 1;
            txtDatePublished.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(3, 10);
            txtDateDrafted.Margin = new Padding(3, 10, 3, 3);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(207, 34);
            txtDateDrafted.TabIndex = 0;
            txtDateDrafted.TextAlign = HorizontalAlignment.Center;
            // 
            // tblStatusDatesLabels
            // 
            tblStatusDatesLabels.ColumnCount = 3;
            tblStatusDatesLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatusDatesLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatusDatesLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatusDatesLabels.Controls.Add(lblDateDrafted, 0, 0);
            tblStatusDatesLabels.Controls.Add(lblDatePublished, 1, 0);
            tblStatusDatesLabels.Controls.Add(lblDateArchived, 2, 0);
            tblStatusDatesLabels.Dock = DockStyle.Fill;
            tblStatusDatesLabels.Location = new Point(3, 3);
            tblStatusDatesLabels.Name = "tblStatusDatesLabels";
            tblStatusDatesLabels.RowCount = 1;
            tblStatusDatesLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatusDatesLabels.Size = new Size(641, 70);
            tblStatusDatesLabels.TabIndex = 7;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(3, 0);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(207, 70);
            lblDateDrafted.TabIndex = 0;
            lblDateDrafted.Text = "Date Drafted";
            lblDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(216, 0);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(207, 70);
            lblDatePublished.TabIndex = 1;
            lblDatePublished.Text = "Date Published";
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(429, 0);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(209, 70);
            lblDateArchived.TabIndex = 2;
            lblDateArchived.Text = "Date Archived";
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblButtons
            // 
            tblButtons.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblButtons.Controls.Add(btnDraft, 0, 0);
            tblButtons.Controls.Add(btnArchive, 2, 0);
            tblButtons.Controls.Add(btnPublish, 1, 0);
            tblButtons.Location = new Point(196, 414);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(647, 50);
            tblButtons.TabIndex = 4;
            // 
            // btnDraft
            // 
            btnDraft.Dock = DockStyle.Fill;
            btnDraft.Location = new Point(15, 3);
            btnDraft.Margin = new Padding(15, 3, 15, 3);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(185, 44);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Dock = DockStyle.Fill;
            btnArchive.Location = new Point(445, 3);
            btnArchive.Margin = new Padding(15, 3, 15, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(187, 44);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Dock = DockStyle.Fill;
            btnPublish.Location = new Point(230, 3);
            btnPublish.Margin = new Padding(15, 3, 15, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(185, 44);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // frmChangeRecipeStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 562);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmChangeRecipeStatus";
            Text = "Recipe - Change Status";
            tblMain.ResumeLayout(false);
            tblStatusDates.ResumeLayout(false);
            tblStatusDatesTxtBoxes.ResumeLayout(false);
            tblStatusDatesTxtBoxes.PerformLayout();
            tblStatusDatesLabels.ResumeLayout(false);
            tblStatusDatesLabels.PerformLayout();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblRecipeStatus;
        private Label lblStatusDates;
        private TableLayoutPanel tblStatusDates;
        private TableLayoutPanel tblStatusDatesTxtBoxes;
        private TextBox txtDateArchived;
        private TextBox txtDatePublished;
        private TextBox txtDateDrafted;
        private TableLayoutPanel tblStatusDatesLabels;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Button btnArchive;
        private Button btnDraft;
        private TableLayoutPanel tblButtons;
        private Button btnPublish;
    }
}