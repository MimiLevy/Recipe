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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.lblStatusDates = new System.Windows.Forms.Label();
            this.tblStatusDates = new System.Windows.Forms.TableLayoutPanel();
            this.tblStatusDatesTxtBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.txtDateArchived = new System.Windows.Forms.TextBox();
            this.txtDatePublished = new System.Windows.Forms.TextBox();
            this.txtDateDrafted = new System.Windows.Forms.TextBox();
            this.tblStatusDatesLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateDrafted = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblDateArchived = new System.Windows.Forms.Label();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblStatusDates.SuspendLayout();
            this.tblStatusDatesTxtBoxes.SuspendLayout();
            this.tblStatusDatesLabels.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.87582F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.12418F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.Controls.Add(this.lblRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.lblRecipeStatus, 0, 1);
            this.tblMain.Controls.Add(this.lblStatusDates, 0, 2);
            this.tblMain.Controls.Add(this.tblStatusDates, 1, 2);
            this.tblMain.Controls.Add(this.tblButtons, 1, 4);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 5;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(846, 562);
            this.tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tblMain.SetColumnSpan(this.lblRecipeName, 3);
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeName.Location = new System.Drawing.Point(4, 14);
            this.lblRecipeName.Margin = new System.Windows.Forms.Padding(4, 14, 4, 14);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(838, 62);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRecipeStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tblMain.SetColumnSpan(this.lblRecipeStatus, 3);
            this.lblRecipeStatus.Location = new System.Drawing.Point(133, 104);
            this.lblRecipeStatus.Margin = new System.Windows.Forms.Padding(4, 14, 4, 14);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(579, 44);
            this.lblRecipeStatus.TabIndex = 1;
            this.lblRecipeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusDates
            // 
            this.lblStatusDates.Location = new System.Drawing.Point(4, 202);
            this.lblStatusDates.Margin = new System.Windows.Forms.Padding(4, 40, 4, 0);
            this.lblStatusDates.Name = "lblStatusDates";
            this.lblStatusDates.Size = new System.Drawing.Size(162, 43);
            this.lblStatusDates.TabIndex = 2;
            this.lblStatusDates.Text = "Status Dates";
            this.lblStatusDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblStatusDates
            // 
            this.tblStatusDates.ColumnCount = 1;
            this.tblMain.SetColumnSpan(this.tblStatusDates, 2);
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStatusDates.Controls.Add(this.tblStatusDatesTxtBoxes, 0, 1);
            this.tblStatusDates.Controls.Add(this.tblStatusDatesLabels, 0, 0);
            this.tblStatusDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatusDates.Location = new System.Drawing.Point(196, 163);
            this.tblStatusDates.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tblStatusDates.Name = "tblStatusDates";
            this.tblStatusDates.RowCount = 2;
            this.tblStatusDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatusDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatusDates.Size = new System.Drawing.Size(647, 152);
            this.tblStatusDates.TabIndex = 3;
            // 
            // tblStatusDatesTxtBoxes
            // 
            this.tblStatusDatesTxtBoxes.ColumnCount = 3;
            this.tblStatusDatesTxtBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDatesTxtBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDatesTxtBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDatesTxtBoxes.Controls.Add(this.txtDateArchived, 0, 0);
            this.tblStatusDatesTxtBoxes.Controls.Add(this.txtDatePublished, 0, 0);
            this.tblStatusDatesTxtBoxes.Controls.Add(this.txtDateDrafted, 0, 0);
            this.tblStatusDatesTxtBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatusDatesTxtBoxes.Location = new System.Drawing.Point(3, 79);
            this.tblStatusDatesTxtBoxes.Name = "tblStatusDatesTxtBoxes";
            this.tblStatusDatesTxtBoxes.RowCount = 1;
            this.tblStatusDatesTxtBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStatusDatesTxtBoxes.Size = new System.Drawing.Size(641, 70);
            this.tblStatusDatesTxtBoxes.TabIndex = 6;
            // 
            // txtDateArchived
            // 
            this.txtDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateArchived.Location = new System.Drawing.Point(429, 10);
            this.txtDateArchived.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtDateArchived.Name = "txtDateArchived";
            this.txtDateArchived.Size = new System.Drawing.Size(209, 34);
            this.txtDateArchived.TabIndex = 2;
            this.txtDateArchived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatePublished.Location = new System.Drawing.Point(216, 10);
            this.txtDatePublished.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.Size = new System.Drawing.Size(207, 34);
            this.txtDatePublished.TabIndex = 1;
            this.txtDatePublished.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateDrafted
            // 
            this.txtDateDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateDrafted.Location = new System.Drawing.Point(3, 10);
            this.txtDateDrafted.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtDateDrafted.Name = "txtDateDrafted";
            this.txtDateDrafted.Size = new System.Drawing.Size(207, 34);
            this.txtDateDrafted.TabIndex = 0;
            this.txtDateDrafted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tblStatusDatesLabels
            // 
            this.tblStatusDatesLabels.ColumnCount = 3;
            this.tblStatusDatesLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDatesLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDatesLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDatesLabels.Controls.Add(this.lblDateDrafted, 0, 0);
            this.tblStatusDatesLabels.Controls.Add(this.lblDatePublished, 1, 0);
            this.tblStatusDatesLabels.Controls.Add(this.lblDateArchived, 2, 0);
            this.tblStatusDatesLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatusDatesLabels.Location = new System.Drawing.Point(3, 3);
            this.tblStatusDatesLabels.Name = "tblStatusDatesLabels";
            this.tblStatusDatesLabels.RowCount = 1;
            this.tblStatusDatesLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStatusDatesLabels.Size = new System.Drawing.Size(641, 70);
            this.tblStatusDatesLabels.TabIndex = 7;
            // 
            // lblDateDrafted
            // 
            this.lblDateDrafted.AutoSize = true;
            this.lblDateDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateDrafted.Location = new System.Drawing.Point(3, 0);
            this.lblDateDrafted.Name = "lblDateDrafted";
            this.lblDateDrafted.Size = new System.Drawing.Size(207, 70);
            this.lblDateDrafted.TabIndex = 0;
            this.lblDateDrafted.Text = "Date Drafted";
            this.lblDateDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePublished.Location = new System.Drawing.Point(216, 0);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(207, 70);
            this.lblDatePublished.TabIndex = 1;
            this.lblDatePublished.Text = "Date Published";
            this.lblDatePublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            this.lblDateArchived.AutoSize = true;
            this.lblDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateArchived.Location = new System.Drawing.Point(429, 0);
            this.lblDateArchived.Name = "lblDateArchived";
            this.lblDateArchived.Size = new System.Drawing.Size(209, 70);
            this.lblDateArchived.TabIndex = 2;
            this.lblDateArchived.Text = "Date Archived";
            this.lblDateArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblButtons
            // 
            this.tblButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblButtons.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblButtons, 2);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.Controls.Add(this.btnDraft, 0, 0);
            this.tblButtons.Controls.Add(this.btnArchive, 2, 0);
            this.tblButtons.Controls.Add(this.btnPublish, 1, 0);
            this.tblButtons.Location = new System.Drawing.Point(196, 414);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.Size = new System.Drawing.Size(647, 50);
            this.tblButtons.TabIndex = 4;
            // 
            // btnDraft
            // 
            this.btnDraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDraft.Location = new System.Drawing.Point(15, 3);
            this.btnDraft.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(185, 44);
            this.btnDraft.TabIndex = 0;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            this.btnArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArchive.Location = new System.Drawing.Point(445, 3);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(187, 44);
            this.btnArchive.TabIndex = 2;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            this.btnPublish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPublish.Location = new System.Drawing.Point(230, 3);
            this.btnPublish.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(185, 44);
            this.btnPublish.TabIndex = 1;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            // 
            // frmChangeRecipeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 562);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChangeRecipeStatus";
            this.Text = "Recipe - Change Status";
            this.tblMain.ResumeLayout(false);
            this.tblStatusDates.ResumeLayout(false);
            this.tblStatusDatesTxtBoxes.ResumeLayout(false);
            this.tblStatusDatesTxtBoxes.PerformLayout();
            this.tblStatusDatesLabels.ResumeLayout(false);
            this.tblStatusDatesLabels.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.ResumeLayout(false);

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