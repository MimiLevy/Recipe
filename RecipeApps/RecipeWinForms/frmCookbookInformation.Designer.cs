namespace RecipeWinForms
{
    partial class frmCookbookInformation
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
            this.btnSaveCookbook = new System.Windows.Forms.Button();
            this.btnDeleteCookbook = new System.Windows.Forms.Button();
            this.lblCookbookName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.txtCookbookName = new System.Windows.Forms.TextBox();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.lblCaptionDateCreated = new System.Windows.Forms.Label();
            this.lblDateDrafted = new System.Windows.Forms.Label();
            this.chkCookbookActive = new System.Windows.Forms.CheckBox();
            this.tblCookbookRecipes = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveRecipes = new System.Windows.Forms.Button();
            this.gDataCookbookRecipes = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.tblMain.SuspendLayout();
            this.tblCookbookRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataCookbookRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.61088F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.91632F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.Controls.Add(this.btnSaveCookbook, 0, 0);
            this.tblMain.Controls.Add(this.btnDeleteCookbook, 1, 0);
            this.tblMain.Controls.Add(this.lblCookbookName, 0, 1);
            this.tblMain.Controls.Add(this.lblUser, 0, 2);
            this.tblMain.Controls.Add(this.lblPrice, 0, 4);
            this.tblMain.Controls.Add(this.lblActive, 0, 5);
            this.tblMain.Controls.Add(this.txtCookbookName, 1, 1);
            this.tblMain.Controls.Add(this.lstUserName, 1, 2);
            this.tblMain.Controls.Add(this.lblCaptionDateCreated, 2, 3);
            this.tblMain.Controls.Add(this.lblDateDrafted, 2, 4);
            this.tblMain.Controls.Add(this.chkCookbookActive, 1, 5);
            this.tblMain.Controls.Add(this.tblCookbookRecipes, 0, 6);
            this.tblMain.Controls.Add(this.txtPrice, 1, 4);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 7;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(485, 773);
            this.tblMain.TabIndex = 0;
            // 
            // btnSaveCookbook
            // 
            this.btnSaveCookbook.AutoSize = true;
            this.btnSaveCookbook.Location = new System.Drawing.Point(4, 4);
            this.btnSaveCookbook.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCookbook.Name = "btnSaveCookbook";
            this.btnSaveCookbook.Size = new System.Drawing.Size(129, 41);
            this.btnSaveCookbook.TabIndex = 0;
            this.btnSaveCookbook.Text = "Save ";
            this.btnSaveCookbook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCookbook
            // 
            this.btnDeleteCookbook.AutoSize = true;
            this.btnDeleteCookbook.Location = new System.Drawing.Point(181, 4);
            this.btnDeleteCookbook.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCookbook.Name = "btnDeleteCookbook";
            this.btnDeleteCookbook.Size = new System.Drawing.Size(129, 41);
            this.btnDeleteCookbook.TabIndex = 1;
            this.btnDeleteCookbook.Text = "Delete";
            this.btnDeleteCookbook.UseVisualStyleBackColor = true;
            // 
            // lblCookbookName
            // 
            this.lblCookbookName.AutoSize = true;
            this.lblCookbookName.Location = new System.Drawing.Point(10, 59);
            this.lblCookbookName.Margin = new System.Windows.Forms.Padding(10, 10, 4, 10);
            this.lblCookbookName.Name = "lblCookbookName";
            this.lblCookbookName.Size = new System.Drawing.Size(161, 28);
            this.lblCookbookName.TabIndex = 2;
            this.lblCookbookName.Text = "Cookbook Name";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(10, 107);
            this.lblUser.Margin = new System.Windows.Forms.Padding(10, 10, 4, 10);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 28);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(10, 203);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(10, 10, 4, 10);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 28);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(10, 251);
            this.lblActive.Margin = new System.Windows.Forms.Padding(10, 10, 4, 10);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(66, 28);
            this.lblActive.TabIndex = 10;
            this.lblActive.Text = "Active";
            // 
            // txtCookbookName
            // 
            this.txtCookbookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.SetColumnSpan(this.txtCookbookName, 2);
            this.txtCookbookName.Location = new System.Drawing.Point(181, 56);
            this.txtCookbookName.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            this.txtCookbookName.Name = "txtCookbookName";
            this.txtCookbookName.Size = new System.Drawing.Size(294, 34);
            this.txtCookbookName.TabIndex = 3;
            // 
            // lstUserName
            // 
            this.lstUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.SetColumnSpan(this.lstUserName, 2);
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(181, 107);
            this.lstUserName.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(294, 36);
            this.lstUserName.TabIndex = 5;
            // 
            // lblCaptionDateCreated
            // 
            this.lblCaptionDateCreated.AutoSize = true;
            this.lblCaptionDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionDateCreated.Location = new System.Drawing.Point(326, 155);
            this.lblCaptionDateCreated.Margin = new System.Windows.Forms.Padding(4, 10, 10, 10);
            this.lblCaptionDateCreated.Name = "lblCaptionDateCreated";
            this.lblCaptionDateCreated.Size = new System.Drawing.Size(149, 28);
            this.lblCaptionDateCreated.TabIndex = 8;
            this.lblCaptionDateCreated.Text = "Date Created:";
            this.lblCaptionDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateDrafted
            // 
            this.lblDateDrafted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateDrafted.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDateDrafted.Location = new System.Drawing.Point(326, 201);
            this.lblDateDrafted.Margin = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.lblDateDrafted.Name = "lblDateDrafted";
            this.lblDateDrafted.Size = new System.Drawing.Size(149, 31);
            this.lblDateDrafted.TabIndex = 9;
            this.lblDateDrafted.Text = " ";
            // 
            // chkCookbookActive
            // 
            this.chkCookbookActive.Location = new System.Drawing.Point(181, 245);
            this.chkCookbookActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkCookbookActive.Name = "chkCookbookActive";
            this.chkCookbookActive.Size = new System.Drawing.Size(135, 33);
            this.chkCookbookActive.TabIndex = 11;
            this.chkCookbookActive.UseVisualStyleBackColor = true;
            // 
            // tblCookbookRecipes
            // 
            this.tblCookbookRecipes.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tblCookbookRecipes.ColumnCount = 1;
            this.tblMain.SetColumnSpan(this.tblCookbookRecipes, 3);
            this.tblCookbookRecipes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCookbookRecipes.Controls.Add(this.btnSaveRecipes, 0, 0);
            this.tblCookbookRecipes.Controls.Add(this.gDataCookbookRecipes, 0, 1);
            this.tblCookbookRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCookbookRecipes.Location = new System.Drawing.Point(4, 293);
            this.tblCookbookRecipes.Margin = new System.Windows.Forms.Padding(4);
            this.tblCookbookRecipes.Name = "tblCookbookRecipes";
            this.tblCookbookRecipes.RowCount = 2;
            this.tblCookbookRecipes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCookbookRecipes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCookbookRecipes.Size = new System.Drawing.Size(477, 476);
            this.tblCookbookRecipes.TabIndex = 12;
            // 
            // btnSaveRecipes
            // 
            this.btnSaveRecipes.Location = new System.Drawing.Point(7, 7);
            this.btnSaveRecipes.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveRecipes.Name = "btnSaveRecipes";
            this.btnSaveRecipes.Size = new System.Drawing.Size(129, 41);
            this.btnSaveRecipes.TabIndex = 0;
            this.btnSaveRecipes.Text = "Save";
            this.btnSaveRecipes.UseVisualStyleBackColor = true;
            // 
            // gDataCookbookRecipes
            // 
            this.gDataCookbookRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gDataCookbookRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDataCookbookRecipes.Location = new System.Drawing.Point(7, 59);
            this.gDataCookbookRecipes.Margin = new System.Windows.Forms.Padding(4);
            this.gDataCookbookRecipes.Name = "gDataCookbookRecipes";
            this.gDataCookbookRecipes.RowHeadersWidth = 51;
            this.gDataCookbookRecipes.RowTemplate.Height = 29;
            this.gDataCookbookRecipes.Size = new System.Drawing.Size(463, 410);
            this.gDataCookbookRecipes.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(181, 200);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(137, 34);
            this.txtPrice.TabIndex = 7;
            // 
            // frmCookbookInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 773);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCookbookInformation";
            this.Text = "Cookbook";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblCookbookRecipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDataCookbookRecipes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSaveCookbook;
        private Button btnDeleteCookbook;
        private Label lblCookbookName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblActive;
        private TextBox txtCookbookName;
        private Label lblCaptionDateCreated;
        private Label lblDateDrafted;
        private TextBox txtPrice;
        private CheckBox chkCookbookActive;
        private TableLayoutPanel tblCookbookRecipes;
        private Button btnSaveRecipes;
        private DataGridView gDataCookbookRecipes;
        private ComboBox lstUserName;
    }
}