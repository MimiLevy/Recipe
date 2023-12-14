namespace RecipeWinForms
{
    partial class frmAutoCreateCookbook
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
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.btnCreateCookbook = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.80649F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.19351F));
            this.tblMain.Controls.Add(this.lstUserName, 0, 0);
            this.tblMain.Controls.Add(this.btnCreateCookbook, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tblMain.Size = new System.Drawing.Size(801, 151);
            this.tblMain.TabIndex = 0;
            // 
            // lstUserName
            // 
            this.lstUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(28, 42);
            this.lstUserName.Margin = new System.Windows.Forms.Padding(28, 42, 28, 26);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(383, 36);
            this.lstUserName.TabIndex = 0;
            // 
            // btnCreateCookbook
            // 
            this.btnCreateCookbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateCookbook.AutoSize = true;
            this.btnCreateCookbook.Location = new System.Drawing.Point(469, 41);
            this.btnCreateCookbook.Margin = new System.Windows.Forms.Padding(30, 3, 3, 25);
            this.btnCreateCookbook.Name = "btnCreateCookbook";
            this.btnCreateCookbook.Size = new System.Drawing.Size(175, 38);
            this.btnCreateCookbook.TabIndex = 1;
            this.btnCreateCookbook.Text = "Create Cookbook";
            this.btnCreateCookbook.UseVisualStyleBackColor = true;
            // 
            // frmAutoCreateCookbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 151);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAutoCreateCookbook";
            this.Text = "Hearty Hearth - Auto-Create a Cookbook";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstUserName;
        private Button btnCreateCookbook;
    }
}