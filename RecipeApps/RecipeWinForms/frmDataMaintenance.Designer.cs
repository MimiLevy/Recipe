namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOptionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.optUsers = new System.Windows.Forms.RadioButton();
            this.optCuisines = new System.Windows.Forms.RadioButton();
            this.optIngredients = new System.Windows.Forms.RadioButton();
            this.optMeasurements = new System.Windows.Forms.RadioButton();
            this.optCourses = new System.Windows.Forms.RadioButton();
            this.gData = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.pnlOptionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.pnlOptionButtons, 0, 0);
            this.tblMain.Controls.Add(this.gData, 1, 0);
            this.tblMain.Controls.Add(this.btnSave, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.73756F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.262436F));
            this.tblMain.Size = new System.Drawing.Size(809, 583);
            this.tblMain.TabIndex = 0;
            // 
            // pnlOptionButtons
            // 
            this.pnlOptionButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlOptionButtons.Controls.Add(this.optUsers);
            this.pnlOptionButtons.Controls.Add(this.optCuisines);
            this.pnlOptionButtons.Controls.Add(this.optIngredients);
            this.pnlOptionButtons.Controls.Add(this.optMeasurements);
            this.pnlOptionButtons.Controls.Add(this.optCourses);
            this.pnlOptionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptionButtons.Location = new System.Drawing.Point(10, 10);
            this.pnlOptionButtons.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.pnlOptionButtons.Name = "pnlOptionButtons";
            this.tblMain.SetRowSpan(this.pnlOptionButtons, 2);
            this.pnlOptionButtons.Size = new System.Drawing.Size(200, 563);
            this.pnlOptionButtons.TabIndex = 0;
            // 
            // optUsers
            // 
            this.optUsers.Checked = true;
            this.optUsers.Location = new System.Drawing.Point(10, 10);
            this.optUsers.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.optUsers.Name = "optUsers";
            this.optUsers.Size = new System.Drawing.Size(169, 37);
            this.optUsers.TabIndex = 1;
            this.optUsers.TabStop = true;
            this.optUsers.Text = "Users";
            this.optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisines
            // 
            this.optCuisines.AutoSize = true;
            this.optCuisines.Location = new System.Drawing.Point(10, 67);
            this.optCuisines.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.optCuisines.Name = "optCuisines";
            this.optCuisines.Size = new System.Drawing.Size(103, 32);
            this.optCuisines.TabIndex = 2;
            this.optCuisines.Text = "Cuisines";
            this.optCuisines.UseVisualStyleBackColor = true;
            // 
            // optIngredients
            // 
            this.optIngredients.AutoSize = true;
            this.optIngredients.Location = new System.Drawing.Point(10, 119);
            this.optIngredients.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.optIngredients.Name = "optIngredients";
            this.optIngredients.Size = new System.Drawing.Size(131, 32);
            this.optIngredients.TabIndex = 3;
            this.optIngredients.Text = "Ingredients";
            this.optIngredients.UseVisualStyleBackColor = true;
            // 
            // optMeasurements
            // 
            this.optMeasurements.AutoSize = true;
            this.optMeasurements.Location = new System.Drawing.Point(10, 171);
            this.optMeasurements.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.optMeasurements.Name = "optMeasurements";
            this.optMeasurements.Size = new System.Drawing.Size(160, 32);
            this.optMeasurements.TabIndex = 4;
            this.optMeasurements.Text = "Measurements";
            this.optMeasurements.UseVisualStyleBackColor = true;
            // 
            // optCourses
            // 
            this.optCourses.AutoSize = true;
            this.optCourses.Location = new System.Drawing.Point(10, 223);
            this.optCourses.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.optCourses.Name = "optCourses";
            this.optCourses.Size = new System.Drawing.Size(101, 32);
            this.optCourses.TabIndex = 0;
            this.optCourses.Text = "Courses";
            this.optCourses.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            this.gData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gData.Location = new System.Drawing.Point(216, 10);
            this.gData.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.gData.Name = "gData";
            this.gData.RowHeadersWidth = 51;
            this.gData.RowTemplate.Height = 29;
            this.gData.Size = new System.Drawing.Size(583, 516);
            this.gData.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(705, 535);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 583);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDataMaintenance";
            this.Text = "Data Maintenance";
            this.tblMain.ResumeLayout(false);
            this.pnlOptionButtons.ResumeLayout(false);
            this.pnlOptionButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private FlowLayoutPanel pnlOptionButtons;
        private RadioButton optUsers;
        private RadioButton optCuisines;
        private RadioButton optIngredients;
        private RadioButton optMeasurements;
        private RadioButton optCourses;
        private DataGridView gData;
        private Button btnSave;
    }
}