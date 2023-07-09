namespace RecipeWinForms
{
    partial class frmRecipe
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
            this.lblCaptionUserName = new System.Windows.Forms.Label();
            this.lblCaptionCuisineType = new System.Windows.Forms.Label();
            this.lblCaptionRecipeName = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.lblCaptionDateCreated = new System.Windows.Forms.Label();
            this.lblCaptionDatePublished = new System.Windows.Forms.Label();
            this.lblCaptionDateArchived = new System.Windows.Forms.Label();
            this.lblCaptionRecipePicture = new System.Windows.Forms.Label();
            this.lblCaptionRecipeStatus = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lstCuisineTypeDesc = new System.Windows.Forms.ComboBox();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRecipePicture = new System.Windows.Forms.Label();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblDateArchived = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.tblMain.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.lblCaptionUserName, 0, 0);
            this.tblMain.Controls.Add(this.lblCaptionCuisineType, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionRecipeName, 0, 2);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 3);
            this.tblMain.Controls.Add(this.lblCaptionDateCreated, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionDatePublished, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionDateArchived, 0, 6);
            this.tblMain.Controls.Add(this.lblCaptionRecipePicture, 0, 8);
            this.tblMain.Controls.Add(this.lblCaptionRecipeStatus, 0, 7);
            this.tblMain.Controls.Add(this.txtCalories, 1, 3);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 2);
            this.tblMain.Controls.Add(this.lstCuisineTypeDesc, 1, 1);
            this.tblMain.Controls.Add(this.lstUserName, 1, 0);
            this.tblMain.Controls.Add(this.tblButtons, 1, 9);
            this.tblMain.Controls.Add(this.lblRecipePicture, 1, 8);
            this.tblMain.Controls.Add(this.lblRecipeStatus, 1, 7);
            this.tblMain.Controls.Add(this.lblDatePublished, 1, 5);
            this.tblMain.Controls.Add(this.lblDateArchived, 1, 6);
            this.tblMain.Controls.Add(this.txtDateCreated, 1, 4);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(5);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 10;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11013F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMain.Size = new System.Drawing.Size(600, 701);
            this.tblMain.TabIndex = 0;
            // 
            // lblCaptionUserName
            // 
            this.lblCaptionUserName.AutoSize = true;
            this.lblCaptionUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaptionUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionUserName.Location = new System.Drawing.Point(5, 0);
            this.lblCaptionUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCaptionUserName.Name = "lblCaptionUserName";
            this.lblCaptionUserName.Size = new System.Drawing.Size(171, 72);
            this.lblCaptionUserName.TabIndex = 0;
            this.lblCaptionUserName.Text = "User Name";
            this.lblCaptionUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionCuisineType
            // 
            this.lblCaptionCuisineType.AutoSize = true;
            this.lblCaptionCuisineType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaptionCuisineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionCuisineType.Location = new System.Drawing.Point(5, 72);
            this.lblCaptionCuisineType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCaptionCuisineType.Name = "lblCaptionCuisineType";
            this.lblCaptionCuisineType.Size = new System.Drawing.Size(171, 72);
            this.lblCaptionCuisineType.TabIndex = 1;
            this.lblCaptionCuisineType.Text = "Cuisine Type";
            this.lblCaptionCuisineType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionRecipeName
            // 
            this.lblCaptionRecipeName.AutoSize = true;
            this.lblCaptionRecipeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaptionRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionRecipeName.Location = new System.Drawing.Point(5, 144);
            this.lblCaptionRecipeName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            this.lblCaptionRecipeName.Size = new System.Drawing.Size(171, 72);
            this.lblCaptionRecipeName.TabIndex = 2;
            this.lblCaptionRecipeName.Text = "Recipe Name";
            this.lblCaptionRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaptionCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionCalories.Location = new System.Drawing.Point(5, 216);
            this.lblCaptionCalories.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(171, 72);
            this.lblCaptionCalories.TabIndex = 3;
            this.lblCaptionCalories.Text = "Calories";
            this.lblCaptionCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionDateCreated
            // 
            this.lblCaptionDateCreated.AutoSize = true;
            this.lblCaptionDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaptionDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionDateCreated.Location = new System.Drawing.Point(5, 288);
            this.lblCaptionDateCreated.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCaptionDateCreated.Name = "lblCaptionDateCreated";
            this.lblCaptionDateCreated.Size = new System.Drawing.Size(171, 72);
            this.lblCaptionDateCreated.TabIndex = 4;
            this.lblCaptionDateCreated.Text = "Date Created";
            this.lblCaptionDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionDatePublished
            // 
            this.lblCaptionDatePublished.AutoSize = true;
            this.lblCaptionDatePublished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaptionDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionDatePublished.Location = new System.Drawing.Point(5, 360);
            this.lblCaptionDatePublished.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            this.lblCaptionDatePublished.Size = new System.Drawing.Size(171, 72);
            this.lblCaptionDatePublished.TabIndex = 5;
            this.lblCaptionDatePublished.Text = "Date Published";
            this.lblCaptionDatePublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionDateArchived
            // 
            this.lblCaptionDateArchived.AutoSize = true;
            this.lblCaptionDateArchived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaptionDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionDateArchived.Location = new System.Drawing.Point(5, 432);
            this.lblCaptionDateArchived.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            this.lblCaptionDateArchived.Size = new System.Drawing.Size(171, 72);
            this.lblCaptionDateArchived.TabIndex = 6;
            this.lblCaptionDateArchived.Text = "Date Archived";
            this.lblCaptionDateArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionRecipePicture
            // 
            this.lblCaptionRecipePicture.AutoSize = true;
            this.lblCaptionRecipePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaptionRecipePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionRecipePicture.Location = new System.Drawing.Point(5, 576);
            this.lblCaptionRecipePicture.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCaptionRecipePicture.Name = "lblCaptionRecipePicture";
            this.lblCaptionRecipePicture.Size = new System.Drawing.Size(171, 72);
            this.lblCaptionRecipePicture.TabIndex = 8;
            this.lblCaptionRecipePicture.Text = "Recipe Picture";
            this.lblCaptionRecipePicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionRecipeStatus
            // 
            this.lblCaptionRecipeStatus.AutoSize = true;
            this.lblCaptionRecipeStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaptionRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionRecipeStatus.Location = new System.Drawing.Point(5, 504);
            this.lblCaptionRecipeStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            this.lblCaptionRecipeStatus.Size = new System.Drawing.Size(171, 72);
            this.lblCaptionRecipeStatus.TabIndex = 7;
            this.lblCaptionRecipeStatus.Text = "Recipe Status";
            this.lblCaptionRecipeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCalories
            // 
            this.txtCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCalories.Location = new System.Drawing.Point(186, 233);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(5);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(409, 38);
            this.txtCalories.TabIndex = 12;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecipeName.Location = new System.Drawing.Point(186, 161);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(5);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(409, 38);
            this.txtRecipeName.TabIndex = 11;
            // 
            // lstCuisineTypeDesc
            // 
            this.lstCuisineTypeDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstCuisineTypeDesc.FormattingEnabled = true;
            this.lstCuisineTypeDesc.Location = new System.Drawing.Point(184, 88);
            this.lstCuisineTypeDesc.Name = "lstCuisineTypeDesc";
            this.lstCuisineTypeDesc.Size = new System.Drawing.Size(206, 39);
            this.lstCuisineTypeDesc.TabIndex = 18;
            // 
            // lstUserName
            // 
            this.lstUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(184, 16);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(206, 39);
            this.lstUserName.TabIndex = 19;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 2;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Controls.Add(this.btnSave, 0, 0);
            this.tblButtons.Controls.Add(this.btnDelete, 1, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(184, 651);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Size = new System.Drawing.Size(413, 47);
            this.tblButtons.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(209, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(201, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblRecipePicture
            // 
            this.lblRecipePicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecipePicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecipePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecipePicture.Location = new System.Drawing.Point(184, 591);
            this.lblRecipePicture.Name = "lblRecipePicture";
            this.lblRecipePicture.Size = new System.Drawing.Size(413, 42);
            this.lblRecipePicture.TabIndex = 21;
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecipeStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecipeStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecipeStatus.Location = new System.Drawing.Point(184, 520);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(413, 40);
            this.lblRecipeStatus.TabIndex = 22;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatePublished.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatePublished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDatePublished.Location = new System.Drawing.Point(184, 378);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(413, 35);
            this.lblDatePublished.TabIndex = 23;
            // 
            // lblDateArchived
            // 
            this.lblDateArchived.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateArchived.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateArchived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateArchived.Location = new System.Drawing.Point(184, 450);
            this.lblDateArchived.Name = "lblDateArchived";
            this.lblDateArchived.Size = new System.Drawing.Size(413, 35);
            this.lblDateArchived.TabIndex = 24;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateCreated.Location = new System.Drawing.Point(184, 305);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.Size = new System.Drawing.Size(413, 38);
            this.txtDateCreated.TabIndex = 25;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 701);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmRecipe";
            this.Text = "Recipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionUserName;
        private Label lblCaptionCuisineType;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCalories;
        private Label lblCaptionDateCreated;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipePicture;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private Label lblCaptionRecipeStatus;
        private ComboBox lstCuisineTypeDesc;
        private ComboBox lstUserName;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private Label lblRecipePicture;
        private Label lblRecipeStatus;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TextBox txtDateCreated;
    }
}