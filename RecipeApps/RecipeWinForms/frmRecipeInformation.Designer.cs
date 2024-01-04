namespace RecipeWinForms
{
    partial class frmRecipeInformation
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
            tblButtons = new TableLayoutPanel();
            btnSaveRecipe = new Button();
            btnDeleteRecipe = new Button();
            btnChangeStatus = new Button();
            lblCaptionRecipeName = new Label();
            lblCaptionCuisine = new Label();
            lblCapytionNumCalories = new Label();
            tbRecipeInfo = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            gDataIngredients = new DataGridView();
            btnSaveIngredients = new Button();
            tbSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnSaveSteps = new Button();
            gDataSteps = new DataGridView();
            lblRecipeStatus = new Label();
            txtCalories = new TextBox();
            txtRecipeName = new TextBox();
            lstCuisineTypeDesc = new ComboBox();
            lstUserName = new ComboBox();
            lblCaptionUser = new Label();
            lblCaptionStatusDates = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblDraftedCaption = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblPublishedCaption = new Label();
            lblArchivedCaption = new Label();
            lblDateDrafted = new Label();
            lblCaptionCurrentStatus = new Label();
            tblStatus = new TableLayoutPanel();
            lblCaptionDrafted = new Label();
            lblCaptionPublished = new Label();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tbRecipeInfo.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDataIngredients).BeginInit();
            tbSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDataSteps).BeginInit();
            tblStatusDates.SuspendLayout();
            tblStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 1);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 3);
            tblMain.Controls.Add(lblCapytionNumCalories, 0, 4);
            tblMain.Controls.Add(tbRecipeInfo, 0, 7);
            tblMain.Controls.Add(lblRecipeStatus, 1, 5);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(lstCuisineTypeDesc, 1, 3);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(lblCaptionUser, 0, 2);
            tblMain.Controls.Add(lblCaptionStatusDates, 0, 6);
            tblMain.Controls.Add(tblStatusDates, 1, 6);
            tblMain.Controls.Add(lblCaptionCurrentStatus, 0, 5);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(636, 765);
            tblMain.TabIndex = 0;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.Controls.Add(btnSaveRecipe, 0, 0);
            tblButtons.Controls.Add(btnDeleteRecipe, 1, 0);
            tblButtons.Controls.Add(btnChangeStatus, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(4, 4);
            tblButtons.Margin = new Padding(4);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(628, 50);
            tblButtons.TabIndex = 0;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.AutoSize = true;
            btnSaveRecipe.Location = new Point(4, 4);
            btnSaveRecipe.Margin = new Padding(4);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(63, 41);
            btnSaveRecipe.TabIndex = 0;
            btnSaveRecipe.Text = "Save";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRecipe
            // 
            btnDeleteRecipe.AutoSize = true;
            btnDeleteRecipe.Location = new Point(75, 4);
            btnDeleteRecipe.Margin = new Padding(4);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(78, 41);
            btnDeleteRecipe.TabIndex = 1;
            btnDeleteRecipe.Text = "Delete";
            btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.Location = new Point(436, 4);
            btnChangeStatus.Margin = new Padding(4, 4, 0, 4);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(192, 42);
            btnChangeStatus.TabIndex = 2;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(4, 68);
            lblCaptionRecipeName.Margin = new Padding(4, 10, 4, 10);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(126, 28);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Location = new Point(4, 162);
            lblCaptionCuisine.Margin = new Padding(4, 10, 4, 10);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(74, 28);
            lblCaptionCuisine.TabIndex = 4;
            lblCaptionCuisine.Text = "Cuisine";
            // 
            // lblCapytionNumCalories
            // 
            lblCapytionNumCalories.AutoSize = true;
            lblCapytionNumCalories.Location = new Point(4, 210);
            lblCapytionNumCalories.Margin = new Padding(4, 10, 4, 10);
            lblCapytionNumCalories.Name = "lblCapytionNumCalories";
            lblCapytionNumCalories.Size = new Size(129, 28);
            lblCapytionNumCalories.TabIndex = 6;
            lblCapytionNumCalories.Text = "Num Calories";
            // 
            // tbRecipeInfo
            // 
            tblMain.SetColumnSpan(tbRecipeInfo, 2);
            tbRecipeInfo.Controls.Add(tbIngredients);
            tbRecipeInfo.Controls.Add(tbSteps);
            tbRecipeInfo.Dock = DockStyle.Fill;
            tbRecipeInfo.Location = new Point(4, 383);
            tbRecipeInfo.Margin = new Padding(4);
            tbRecipeInfo.Name = "tbRecipeInfo";
            tbRecipeInfo.SelectedIndex = 0;
            tbRecipeInfo.Size = new Size(628, 378);
            tbRecipeInfo.TabIndex = 12;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Location = new Point(4, 37);
            tbIngredients.Margin = new Padding(4);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(4);
            tbIngredients.Size = new Size(620, 337);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblIngredients.Controls.Add(gDataIngredients, 0, 1);
            tblIngredients.Controls.Add(btnSaveIngredients, 0, 0);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(4, 4);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblIngredients.Size = new Size(612, 329);
            tblIngredients.TabIndex = 0;
            // 
            // gDataIngredients
            // 
            gDataIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDataIngredients.Dock = DockStyle.Fill;
            gDataIngredients.Location = new Point(3, 47);
            gDataIngredients.Name = "gDataIngredients";
            gDataIngredients.RowHeadersWidth = 51;
            gDataIngredients.RowTemplate.Height = 29;
            gDataIngredients.Size = new Size(606, 279);
            gDataIngredients.TabIndex = 1;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.AutoSize = true;
            btnSaveIngredients.Location = new Point(3, 3);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(94, 38);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "Save";
            btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Location = new Point(4, 29);
            tbSteps.Margin = new Padding(4);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(4);
            tbSteps.Size = new Size(620, 375);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSteps.Controls.Add(btnSaveSteps, 0, 0);
            tblSteps.Controls.Add(gDataSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(4, 4);
            tblSteps.Margin = new Padding(10, 3, 3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSteps.Size = new Size(612, 367);
            tblSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.AutoSize = true;
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(94, 38);
            btnSaveSteps.TabIndex = 0;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gDataSteps
            // 
            gDataSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDataSteps.Dock = DockStyle.Fill;
            gDataSteps.Location = new Point(3, 47);
            gDataSteps.Name = "gDataSteps";
            gDataSteps.RowHeadersWidth = 51;
            gDataSteps.RowTemplate.Height = 29;
            gDataSteps.Size = new Size(606, 317);
            gDataSteps.TabIndex = 1;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeStatus.BackColor = SystemColors.AppWorkspace;
            lblRecipeStatus.BorderStyle = BorderStyle.FixedSingle;
            lblRecipeStatus.Location = new Point(217, 256);
            lblRecipeStatus.Margin = new Padding(4, 0, 4, 0);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(415, 32);
            lblRecipeStatus.TabIndex = 9;
            // 
            // txtCalories
            // 
            txtCalories.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCalories.Location = new Point(217, 207);
            txtCalories.Margin = new Padding(4);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(415, 34);
            txtCalories.TabIndex = 7;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtRecipeName.Location = new Point(217, 65);
            txtRecipeName.Margin = new Padding(4);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(415, 34);
            txtRecipeName.TabIndex = 1;
            // 
            // lstCuisineTypeDesc
            // 
            lstCuisineTypeDesc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstCuisineTypeDesc.FormattingEnabled = true;
            lstCuisineTypeDesc.Location = new Point(217, 162);
            lstCuisineTypeDesc.Margin = new Padding(4);
            lstCuisineTypeDesc.Name = "lstCuisineTypeDesc";
            lstCuisineTypeDesc.Size = new Size(415, 36);
            lstCuisineTypeDesc.TabIndex = 5;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(217, 115);
            lstUserName.Margin = new Padding(4);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(415, 36);
            lstUserName.TabIndex = 3;
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Location = new Point(4, 116);
            lblCaptionUser.Margin = new Padding(4, 10, 4, 10);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(51, 26);
            lblCaptionUser.TabIndex = 2;
            lblCaptionUser.Text = "User";
            // 
            // lblCaptionStatusDates
            // 
            lblCaptionStatusDates.AutoSize = true;
            lblCaptionStatusDates.Location = new Point(4, 326);
            lblCaptionStatusDates.Margin = new Padding(4, 30, 4, 10);
            lblCaptionStatusDates.Name = "lblCaptionStatusDates";
            lblCaptionStatusDates.Size = new Size(119, 28);
            lblCaptionStatusDates.TabIndex = 10;
            lblCaptionStatusDates.Text = "Status Dates";
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 3;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatusDates.Controls.Add(lblDraftedCaption, 0, 0);
            tblStatusDates.Controls.Add(lblDatePublished, 1, 1);
            tblStatusDates.Controls.Add(lblDateArchived, 2, 1);
            tblStatusDates.Controls.Add(lblPublishedCaption, 1, 0);
            tblStatusDates.Controls.Add(lblArchivedCaption, 2, 0);
            tblStatusDates.Controls.Add(lblDateDrafted, 0, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(216, 299);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.Size = new Size(417, 77);
            tblStatusDates.TabIndex = 14;
            // 
            // lblDraftedCaption
            // 
            lblDraftedCaption.Anchor = AnchorStyles.None;
            lblDraftedCaption.AutoSize = true;
            lblDraftedCaption.Location = new Point(30, 5);
            lblDraftedCaption.Name = "lblDraftedCaption";
            lblDraftedCaption.Size = new Size(78, 28);
            lblDraftedCaption.TabIndex = 0;
            lblDraftedCaption.Text = "Drafted";
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.None;
            lblDatePublished.BackColor = SystemColors.AppWorkspace;
            lblDatePublished.Location = new Point(144, 42);
            lblDatePublished.Margin = new Padding(4);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(129, 31);
            lblDatePublished.TabIndex = 3;
            lblDatePublished.Text = " ";
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.None;
            lblDateArchived.BackColor = SystemColors.AppWorkspace;
            lblDateArchived.Location = new Point(282, 42);
            lblDateArchived.Margin = new Padding(4);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(130, 31);
            lblDateArchived.TabIndex = 5;
            lblDateArchived.Text = " ";
            // 
            // lblPublishedCaption
            // 
            lblPublishedCaption.Anchor = AnchorStyles.None;
            lblPublishedCaption.AutoSize = true;
            lblPublishedCaption.Location = new Point(160, 5);
            lblPublishedCaption.Name = "lblPublishedCaption";
            lblPublishedCaption.Size = new Size(97, 28);
            lblPublishedCaption.TabIndex = 2;
            lblPublishedCaption.Text = "Published";
            // 
            // lblArchivedCaption
            // 
            lblArchivedCaption.Anchor = AnchorStyles.None;
            lblArchivedCaption.AutoSize = true;
            lblArchivedCaption.Location = new Point(303, 5);
            lblArchivedCaption.Name = "lblArchivedCaption";
            lblArchivedCaption.Size = new Size(89, 28);
            lblArchivedCaption.TabIndex = 4;
            lblArchivedCaption.Text = "Archived";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.None;
            lblDateDrafted.BackColor = SystemColors.AppWorkspace;
            lblDateDrafted.Location = new Point(5, 42);
            lblDateDrafted.Margin = new Padding(4);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(129, 31);
            lblDateDrafted.TabIndex = 1;
            lblDateDrafted.Text = " ";
            // 
            // lblCaptionCurrentStatus
            // 
            lblCaptionCurrentStatus.AutoSize = true;
            lblCaptionCurrentStatus.Location = new Point(4, 258);
            lblCaptionCurrentStatus.Margin = new Padding(4, 10, 4, 10);
            lblCaptionCurrentStatus.Name = "lblCaptionCurrentStatus";
            lblCaptionCurrentStatus.Size = new Size(135, 28);
            lblCaptionCurrentStatus.TabIndex = 8;
            lblCaptionCurrentStatus.Text = "Current Status";
            // 
            // tblStatus
            // 
            tblStatus.ColumnCount = 3;
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatus.Controls.Add(lblCaptionDrafted, 0, 0);
            tblStatus.Location = new Point(0, 0);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 1;
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblStatus.Size = new Size(200, 100);
            tblStatus.TabIndex = 0;
            // 
            // lblCaptionDrafted
            // 
            lblCaptionDrafted.AutoSize = true;
            lblCaptionDrafted.Dock = DockStyle.Fill;
            lblCaptionDrafted.Location = new Point(4, 5);
            lblCaptionDrafted.Margin = new Padding(4, 5, 4, 0);
            lblCaptionDrafted.Name = "lblCaptionDrafted";
            lblCaptionDrafted.Size = new Size(58, 95);
            lblCaptionDrafted.TabIndex = 0;
            lblCaptionDrafted.Text = "Drafted";
            lblCaptionDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCaptionPublished
            // 
            lblCaptionPublished.AutoSize = true;
            lblCaptionPublished.Dock = DockStyle.Fill;
            lblCaptionPublished.Location = new Point(70, 5);
            lblCaptionPublished.Margin = new Padding(4, 5, 4, 0);
            lblCaptionPublished.Name = "lblCaptionPublished";
            lblCaptionPublished.Size = new Size(58, 95);
            lblCaptionPublished.TabIndex = 1;
            lblCaptionPublished.Text = "Pulished";
            lblCaptionPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRecipeInformation
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 765);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmRecipeInformation";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tbRecipeInfo.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDataIngredients).EndInit();
            tbSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDataSteps).EndInit();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblButtons;
        private Button btnSaveRecipe;
        private Button btnDeleteRecipe;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCuisine;
        private Label lblCapytionNumCalories;
        private Label lblCaptionCurrentStatus;
        private Label lblCaptionStatusDates;
        private TabControl tbRecipeInfo;
        private TabPage tbIngredients;
        private TabPage tbSteps;
        private Label lblRecipeStatus;
        private TextBox txtCalories;
        private TextBox txtRecipeName;
        private ComboBox lstCuisineTypeDesc;
        private Button btnChangeStatus;
        private TableLayoutPanel tblIngredients;
        private DataGridView gDataIngredients;
        private Button tnSaveIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private DataGridView gDataSteps;
        private ComboBox lstUserName;
        private Label lblCaptionUser;
        private TableLayoutPanel tblStatus;
        private Label lblCaptionDrafted;
        private Label lblCaptionPublished;
        private TableLayoutPanel tblStatusDates;
        private Label lblDraftedCaption;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblPublishedCaption;
        private Label lblArchivedCaption;
        private Button btnSaveIngredients;
    }
}