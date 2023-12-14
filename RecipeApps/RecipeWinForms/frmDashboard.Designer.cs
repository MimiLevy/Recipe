namespace RecipeWinForms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnRecipeList = new System.Windows.Forms.Button();
            this.btnMealList = new System.Windows.Forms.Button();
            this.btnCookbookList = new System.Windows.Forms.Button();
            this.gData = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            this.tblButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.lblCaption, 0, 0);
            this.tblMain.Controls.Add(this.lblDesc, 0, 1);
            this.tblMain.Controls.Add(this.tblButtons, 0, 3);
            this.tblMain.Controls.Add(this.gData, 0, 2);
            this.tblMain.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1399, 752);
            this.tblMain.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Georgia Pro", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaption.Location = new System.Drawing.Point(3, 20);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(1393, 43);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Hearty Hearth Desktop Application";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesc.Font = new System.Drawing.Font("Dubai Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDesc.Location = new System.Drawing.Point(3, 93);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(1393, 203);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = resources.GetString("lblDesc.Text");
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 3;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.Controls.Add(this.btnRecipeList, 0, 0);
            this.tblButtons.Controls.Add(this.btnMealList, 1, 0);
            this.tblButtons.Controls.Add(this.btnCookbookList, 2, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(3, 532);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.Size = new System.Drawing.Size(1393, 217);
            this.tblButtons.TabIndex = 2;
            // 
            // btnRecipeList
            // 
            this.btnRecipeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRecipeList.BackColor = System.Drawing.Color.Coral;
            this.btnRecipeList.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecipeList.Location = new System.Drawing.Point(132, 40);
            this.btnRecipeList.Margin = new System.Windows.Forms.Padding(3, 40, 3, 130);
            this.btnRecipeList.Name = "btnRecipeList";
            this.btnRecipeList.Size = new System.Drawing.Size(200, 47);
            this.btnRecipeList.TabIndex = 0;
            this.btnRecipeList.Text = "Recipe List";
            this.btnRecipeList.UseVisualStyleBackColor = false;
            // 
            // btnMealList
            // 
            this.btnMealList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMealList.BackColor = System.Drawing.Color.Coral;
            this.btnMealList.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMealList.Location = new System.Drawing.Point(596, 40);
            this.btnMealList.Margin = new System.Windows.Forms.Padding(3, 40, 3, 130);
            this.btnMealList.Name = "btnMealList";
            this.btnMealList.Size = new System.Drawing.Size(200, 47);
            this.btnMealList.TabIndex = 1;
            this.btnMealList.Text = "Meal List";
            this.btnMealList.UseVisualStyleBackColor = false;
            // 
            // btnCookbookList
            // 
            this.btnCookbookList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCookbookList.BackColor = System.Drawing.Color.Coral;
            this.btnCookbookList.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCookbookList.Location = new System.Drawing.Point(1060, 40);
            this.btnCookbookList.Margin = new System.Windows.Forms.Padding(3, 40, 3, 130);
            this.btnCookbookList.Name = "btnCookbookList";
            this.btnCookbookList.Size = new System.Drawing.Size(200, 47);
            this.btnCookbookList.TabIndex = 2;
            this.btnCookbookList.Text = "Cookbook List";
            this.btnCookbookList.UseVisualStyleBackColor = false;
            // 
            // gData
            // 
            this.gData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gData.DefaultCellStyle = dataGridViewCellStyle2;
            this.gData.Location = new System.Drawing.Point(550, 316);
            this.gData.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.gData.Name = "gData";
            this.gData.RowHeadersWidth = 51;
            this.gData.Size = new System.Drawing.Size(299, 203);
            this.gData.TabIndex = 3;
            this.gData.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 752);
            this.Controls.Add(this.tblMain);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tblMain;
        private Label lblCaption;
        private Label lblDesc;
        private TableLayoutPanel tblButtons;
        private DataGridView gData;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}