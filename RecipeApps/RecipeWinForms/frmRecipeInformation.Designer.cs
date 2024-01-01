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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.lblCaptionRecipeName = new System.Windows.Forms.Label();
            this.lblCaptionCuisine = new System.Windows.Forms.Label();
            this.lblCapytionNumCalories = new System.Windows.Forms.Label();
            this.tbRecipeInfo = new System.Windows.Forms.TabControl();
            this.tbIngredients = new System.Windows.Forms.TabPage();
            this.tblIngredients = new System.Windows.Forms.TableLayoutPanel();
            this.gDataIngredients = new System.Windows.Forms.DataGridView();
            this.btnSaveIngredients = new System.Windows.Forms.Button();
            this.tbSteps = new System.Windows.Forms.TabPage();
            this.tblSteps = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveSteps = new System.Windows.Forms.Button();
            this.gDataSteps = new System.Windows.Forms.DataGridView();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lstCuisineTypeDesc = new System.Windows.Forms.ComboBox();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.lblCaptionUser = new System.Windows.Forms.Label();
            this.lblCaptionStatusDates = new System.Windows.Forms.Label();
            this.tblStatusDates = new System.Windows.Forms.TableLayoutPanel();
            this.lblDraftedCaption = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblDateArchived = new System.Windows.Forms.Label();
            this.lblPublishedCaption = new System.Windows.Forms.Label();
            this.lblArchivedCaption = new System.Windows.Forms.Label();
            this.lblDateDrafted = new System.Windows.Forms.Label();
            this.lblCaptionCurrentStatus = new System.Windows.Forms.Label();
            this.tblStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaptionDrafted = new System.Windows.Forms.Label();
            this.lblCaptionPublished = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.tbRecipeInfo.SuspendLayout();
            this.tbIngredients.SuspendLayout();
            this.tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataIngredients)).BeginInit();
            this.tbSteps.SuspendLayout();
            this.tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataSteps)).BeginInit();
            this.tblStatusDates.SuspendLayout();
            this.tblStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblMain.Controls.Add(this.tblButtons, 0, 0);
            this.tblMain.Controls.Add(this.lblCaptionRecipeName, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionCuisine, 0, 3);
            this.tblMain.Controls.Add(this.lblCapytionNumCalories, 0, 4);
            this.tblMain.Controls.Add(this.tbRecipeInfo, 0, 7);
            this.tblMain.Controls.Add(this.lblRecipeStatus, 1, 5);
            this.tblMain.Controls.Add(this.txtCalories, 1, 4);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 1);
            this.tblMain.Controls.Add(this.lstCuisineTypeDesc, 1, 3);
            this.tblMain.Controls.Add(this.lstUserName, 1, 2);
            this.tblMain.Controls.Add(this.lblCaptionUser, 0, 2);
            this.tblMain.Controls.Add(this.lblCaptionStatusDates, 0, 6);
            this.tblMain.Controls.Add(this.tblStatusDates, 1, 6);
            this.tblMain.Controls.Add(this.lblCaptionCurrentStatus, 0, 5);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(636, 765);
            this.tblMain.TabIndex = 0;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblButtons, 2);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.Controls.Add(this.btnSaveRecipe, 0, 0);
            this.tblButtons.Controls.Add(this.btnDeleteRecipe, 1, 0);
            this.tblButtons.Controls.Add(this.btnChangeStatus, 2, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(4, 4);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtons.Size = new System.Drawing.Size(628, 50);
            this.tblButtons.TabIndex = 0;
            // 
            // btnSaveRecipe
            // 
            this.btnSaveRecipe.AutoSize = true;
            this.btnSaveRecipe.Location = new System.Drawing.Point(4, 4);
            this.btnSaveRecipe.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveRecipe.Name = "btnSaveRecipe";
            this.btnSaveRecipe.Size = new System.Drawing.Size(63, 41);
            this.btnSaveRecipe.TabIndex = 0;
            this.btnSaveRecipe.Text = "Save";
            this.btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.AutoSize = true;
            this.btnDeleteRecipe.Location = new System.Drawing.Point(75, 4);
            this.btnDeleteRecipe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(78, 41);
            this.btnDeleteRecipe.TabIndex = 1;
            this.btnDeleteRecipe.Text = "Delete";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeStatus.AutoSize = true;
            this.btnChangeStatus.Location = new System.Drawing.Point(436, 4);
            this.btnChangeStatus.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(192, 42);
            this.btnChangeStatus.TabIndex = 2;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // lblCaptionRecipeName
            // 
            this.lblCaptionRecipeName.AutoSize = true;
            this.lblCaptionRecipeName.Location = new System.Drawing.Point(4, 68);
            this.lblCaptionRecipeName.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            this.lblCaptionRecipeName.Size = new System.Drawing.Size(126, 28);
            this.lblCaptionRecipeName.TabIndex = 0;
            this.lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCuisine
            // 
            this.lblCaptionCuisine.AutoSize = true;
            this.lblCaptionCuisine.Location = new System.Drawing.Point(4, 162);
            this.lblCaptionCuisine.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.lblCaptionCuisine.Name = "lblCaptionCuisine";
            this.lblCaptionCuisine.Size = new System.Drawing.Size(74, 28);
            this.lblCaptionCuisine.TabIndex = 4;
            this.lblCaptionCuisine.Text = "Cuisine";
            // 
            // lblCapytionNumCalories
            // 
            this.lblCapytionNumCalories.AutoSize = true;
            this.lblCapytionNumCalories.Location = new System.Drawing.Point(4, 210);
            this.lblCapytionNumCalories.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.lblCapytionNumCalories.Name = "lblCapytionNumCalories";
            this.lblCapytionNumCalories.Size = new System.Drawing.Size(129, 28);
            this.lblCapytionNumCalories.TabIndex = 6;
            this.lblCapytionNumCalories.Text = "Num Calories";
            // 
            // tbRecipeInfo
            // 
            this.tblMain.SetColumnSpan(this.tbRecipeInfo, 2);
            this.tbRecipeInfo.Controls.Add(this.tbIngredients);
            this.tbRecipeInfo.Controls.Add(this.tbSteps);
            this.tbRecipeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRecipeInfo.Location = new System.Drawing.Point(4, 383);
            this.tbRecipeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecipeInfo.Name = "tbRecipeInfo";
            this.tbRecipeInfo.SelectedIndex = 0;
            this.tbRecipeInfo.Size = new System.Drawing.Size(628, 378);
            this.tbRecipeInfo.TabIndex = 12;
            // 
            // tbIngredients
            // 
            this.tbIngredients.Controls.Add(this.tblIngredients);
            this.tbIngredients.Location = new System.Drawing.Point(4, 37);
            this.tbIngredients.Margin = new System.Windows.Forms.Padding(4);
            this.tbIngredients.Name = "tbIngredients";
            this.tbIngredients.Padding = new System.Windows.Forms.Padding(4);
            this.tbIngredients.Size = new System.Drawing.Size(620, 337);
            this.tbIngredients.TabIndex = 0;
            this.tbIngredients.Text = "Ingredients";
            this.tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            this.tblIngredients.ColumnCount = 1;
            this.tblIngredients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIngredients.Controls.Add(this.gDataIngredients, 0, 1);
            this.tblIngredients.Controls.Add(this.btnSaveIngredients, 0, 0);
            this.tblIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblIngredients.Location = new System.Drawing.Point(4, 4);
            this.tblIngredients.Name = "tblIngredients";
            this.tblIngredients.RowCount = 2;
            this.tblIngredients.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIngredients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIngredients.Size = new System.Drawing.Size(612, 329);
            this.tblIngredients.TabIndex = 0;
            // 
            // gDataIngredients
            // 
            this.gDataIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gDataIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDataIngredients.Location = new System.Drawing.Point(3, 47);
            this.gDataIngredients.Name = "gDataIngredients";
            this.gDataIngredients.RowHeadersWidth = 51;
            this.gDataIngredients.RowTemplate.Height = 29;
            this.gDataIngredients.Size = new System.Drawing.Size(606, 279);
            this.gDataIngredients.TabIndex = 1;
            // 
            // btnSaveIngredients
            // 
            this.btnSaveIngredients.AutoSize = true;
            this.btnSaveIngredients.Location = new System.Drawing.Point(3, 3);
            this.btnSaveIngredients.Name = "btnSaveIngredients";
            this.btnSaveIngredients.Size = new System.Drawing.Size(94, 38);
            this.btnSaveIngredients.TabIndex = 0;
            this.btnSaveIngredients.Text = "Save";
            this.btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // tbSteps
            // 
            this.tbSteps.Controls.Add(this.tblSteps);
            this.tbSteps.Location = new System.Drawing.Point(4, 29);
            this.tbSteps.Margin = new System.Windows.Forms.Padding(4);
            this.tbSteps.Name = "tbSteps";
            this.tbSteps.Padding = new System.Windows.Forms.Padding(4);
            this.tbSteps.Size = new System.Drawing.Size(620, 375);
            this.tbSteps.TabIndex = 1;
            this.tbSteps.Text = "Steps";
            this.tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            this.tblSteps.ColumnCount = 1;
            this.tblSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSteps.Controls.Add(this.btnSaveSteps, 0, 0);
            this.tblSteps.Controls.Add(this.gDataSteps, 0, 1);
            this.tblSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSteps.Location = new System.Drawing.Point(4, 4);
            this.tblSteps.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tblSteps.Name = "tblSteps";
            this.tblSteps.RowCount = 2;
            this.tblSteps.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSteps.Size = new System.Drawing.Size(612, 367);
            this.tblSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            this.btnSaveSteps.AutoSize = true;
            this.btnSaveSteps.Location = new System.Drawing.Point(3, 3);
            this.btnSaveSteps.Name = "btnSaveSteps";
            this.btnSaveSteps.Size = new System.Drawing.Size(94, 38);
            this.btnSaveSteps.TabIndex = 0;
            this.btnSaveSteps.Text = "Save";
            this.btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gDataSteps
            // 
            this.gDataSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gDataSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDataSteps.Location = new System.Drawing.Point(3, 47);
            this.gDataSteps.Name = "gDataSteps";
            this.gDataSteps.RowHeadersWidth = 51;
            this.gDataSteps.RowTemplate.Height = 29;
            this.gDataSteps.Size = new System.Drawing.Size(606, 317);
            this.gDataSteps.TabIndex = 1;
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecipeStatus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRecipeStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecipeStatus.Location = new System.Drawing.Point(217, 256);
            this.lblRecipeStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(415, 32);
            this.lblRecipeStatus.TabIndex = 9;
            // 
            // txtCalories
            // 
            this.txtCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCalories.Location = new System.Drawing.Point(217, 207);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(415, 34);
            this.txtCalories.TabIndex = 7;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecipeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeName.Location = new System.Drawing.Point(217, 65);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(415, 34);
            this.txtRecipeName.TabIndex = 1;
            // 
            // lstCuisineTypeDesc
            // 
            this.lstCuisineTypeDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCuisineTypeDesc.FormattingEnabled = true;
            this.lstCuisineTypeDesc.Location = new System.Drawing.Point(217, 158);
            this.lstCuisineTypeDesc.Margin = new System.Windows.Forms.Padding(4);
            this.lstCuisineTypeDesc.Name = "lstCuisineTypeDesc";
            this.lstCuisineTypeDesc.Size = new System.Drawing.Size(415, 36);
            this.lstCuisineTypeDesc.TabIndex = 5;
            // 
            // lstUserName
            // 
            this.lstUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(217, 111);
            this.lstUserName.Margin = new System.Windows.Forms.Padding(4);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(415, 36);
            this.lstUserName.TabIndex = 3;
            // 
            // lblCaptionUser
            // 
            this.lblCaptionUser.AutoSize = true;
            this.lblCaptionUser.Location = new System.Drawing.Point(4, 116);
            this.lblCaptionUser.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.lblCaptionUser.Name = "lblCaptionUser";
            this.lblCaptionUser.Size = new System.Drawing.Size(51, 26);
            this.lblCaptionUser.TabIndex = 2;
            this.lblCaptionUser.Text = "User";
            // 
            // lblCaptionStatusDates
            // 
            this.lblCaptionStatusDates.AutoSize = true;
            this.lblCaptionStatusDates.Location = new System.Drawing.Point(4, 326);
            this.lblCaptionStatusDates.Margin = new System.Windows.Forms.Padding(4, 30, 4, 10);
            this.lblCaptionStatusDates.Name = "lblCaptionStatusDates";
            this.lblCaptionStatusDates.Size = new System.Drawing.Size(119, 28);
            this.lblCaptionStatusDates.TabIndex = 10;
            this.lblCaptionStatusDates.Text = "Status Dates";
            // 
            // tblStatusDates
            // 
            this.tblStatusDates.ColumnCount = 3;
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDates.Controls.Add(this.lblDraftedCaption, 0, 0);
            this.tblStatusDates.Controls.Add(this.lblDatePublished, 1, 1);
            this.tblStatusDates.Controls.Add(this.lblDateArchived, 2, 1);
            this.tblStatusDates.Controls.Add(this.lblPublishedCaption, 1, 0);
            this.tblStatusDates.Controls.Add(this.lblArchivedCaption, 2, 0);
            this.tblStatusDates.Controls.Add(this.lblDateDrafted, 0, 1);
            this.tblStatusDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatusDates.Location = new System.Drawing.Point(216, 299);
            this.tblStatusDates.Name = "tblStatusDates";
            this.tblStatusDates.RowCount = 2;
            this.tblStatusDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatusDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatusDates.Size = new System.Drawing.Size(417, 77);
            this.tblStatusDates.TabIndex = 14;
            // 
            // lblDraftedCaption
            // 
            this.lblDraftedCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDraftedCaption.AutoSize = true;
            this.lblDraftedCaption.Location = new System.Drawing.Point(30, 5);
            this.lblDraftedCaption.Name = "lblDraftedCaption";
            this.lblDraftedCaption.Size = new System.Drawing.Size(78, 28);
            this.lblDraftedCaption.TabIndex = 0;
            this.lblDraftedCaption.Text = "Drafted";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatePublished.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDatePublished.Location = new System.Drawing.Point(144, 42);
            this.lblDatePublished.Margin = new System.Windows.Forms.Padding(4);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(129, 31);
            this.lblDatePublished.TabIndex = 3;
            this.lblDatePublished.Text = " ";
            // 
            // lblDateArchived
            // 
            this.lblDateArchived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateArchived.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDateArchived.Location = new System.Drawing.Point(282, 42);
            this.lblDateArchived.Margin = new System.Windows.Forms.Padding(4);
            this.lblDateArchived.Name = "lblDateArchived";
            this.lblDateArchived.Size = new System.Drawing.Size(130, 31);
            this.lblDateArchived.TabIndex = 5;
            this.lblDateArchived.Text = " ";
            // 
            // lblPublishedCaption
            // 
            this.lblPublishedCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPublishedCaption.AutoSize = true;
            this.lblPublishedCaption.Location = new System.Drawing.Point(160, 5);
            this.lblPublishedCaption.Name = "lblPublishedCaption";
            this.lblPublishedCaption.Size = new System.Drawing.Size(97, 28);
            this.lblPublishedCaption.TabIndex = 2;
            this.lblPublishedCaption.Text = "Published";
            // 
            // lblArchivedCaption
            // 
            this.lblArchivedCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArchivedCaption.AutoSize = true;
            this.lblArchivedCaption.Location = new System.Drawing.Point(303, 5);
            this.lblArchivedCaption.Name = "lblArchivedCaption";
            this.lblArchivedCaption.Size = new System.Drawing.Size(89, 28);
            this.lblArchivedCaption.TabIndex = 4;
            this.lblArchivedCaption.Text = "Archived";
            // 
            // lblDateDrafted
            // 
            this.lblDateDrafted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateDrafted.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDateDrafted.Location = new System.Drawing.Point(5, 42);
            this.lblDateDrafted.Margin = new System.Windows.Forms.Padding(4);
            this.lblDateDrafted.Name = "lblDateDrafted";
            this.lblDateDrafted.Size = new System.Drawing.Size(129, 31);
            this.lblDateDrafted.TabIndex = 1;
            this.lblDateDrafted.Text = " ";
            // 
            // lblCaptionCurrentStatus
            // 
            this.lblCaptionCurrentStatus.AutoSize = true;
            this.lblCaptionCurrentStatus.Location = new System.Drawing.Point(4, 258);
            this.lblCaptionCurrentStatus.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.lblCaptionCurrentStatus.Name = "lblCaptionCurrentStatus";
            this.lblCaptionCurrentStatus.Size = new System.Drawing.Size(135, 28);
            this.lblCaptionCurrentStatus.TabIndex = 8;
            this.lblCaptionCurrentStatus.Text = "Current Status";
            // 
            // tblStatus
            // 
            this.tblStatus.ColumnCount = 3;
            this.tblStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatus.Controls.Add(this.lblCaptionDrafted, 0, 0);
            this.tblStatus.Location = new System.Drawing.Point(0, 0);
            this.tblStatus.Name = "tblStatus";
            this.tblStatus.RowCount = 1;
            this.tblStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStatus.Size = new System.Drawing.Size(200, 100);
            this.tblStatus.TabIndex = 0;
            // 
            // lblCaptionDrafted
            // 
            this.lblCaptionDrafted.AutoSize = true;
            this.lblCaptionDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionDrafted.Location = new System.Drawing.Point(4, 5);
            this.lblCaptionDrafted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.lblCaptionDrafted.Name = "lblCaptionDrafted";
            this.lblCaptionDrafted.Size = new System.Drawing.Size(58, 95);
            this.lblCaptionDrafted.TabIndex = 0;
            this.lblCaptionDrafted.Text = "Drafted";
            this.lblCaptionDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionPublished
            // 
            this.lblCaptionPublished.AutoSize = true;
            this.lblCaptionPublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionPublished.Location = new System.Drawing.Point(70, 5);
            this.lblCaptionPublished.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.lblCaptionPublished.Name = "lblCaptionPublished";
            this.lblCaptionPublished.Size = new System.Drawing.Size(58, 95);
            this.lblCaptionPublished.TabIndex = 1;
            this.lblCaptionPublished.Text = "Pulished";
            this.lblCaptionPublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRecipeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 765);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecipeInformation";
            this.Text = "Recipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.tblButtons.PerformLayout();
            this.tbRecipeInfo.ResumeLayout(false);
            this.tbIngredients.ResumeLayout(false);
            this.tblIngredients.ResumeLayout(false);
            this.tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataIngredients)).EndInit();
            this.tbSteps.ResumeLayout(false);
            this.tblSteps.ResumeLayout(false);
            this.tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataSteps)).EndInit();
            this.tblStatusDates.ResumeLayout(false);
            this.tblStatusDates.PerformLayout();
            this.tblStatus.ResumeLayout(false);
            this.tblStatus.PerformLayout();
            this.ResumeLayout(false);

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