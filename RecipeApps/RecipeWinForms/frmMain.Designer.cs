namespace RecipeWinForms
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecipes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecipeList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecipeInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloneRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMeals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMealList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCookbooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCookbookList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCookbookInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoCreateCookbook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataMaintenanceMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowsTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRecipes,
            this.mnuMeals,
            this.mnuCookbooks,
            this.mnuDataMaintenanceMain,
            this.mnuWindows});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mnuMain.Size = new System.Drawing.Size(1054, 38);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDashboard});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuFile.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(59, 32);
            this.mnuFile.Text = "File";
            // 
            // mnuDashboard
            // 
            this.mnuDashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuDashboard.Name = "mnuDashboard";
            this.mnuDashboard.Size = new System.Drawing.Size(200, 32);
            this.mnuDashboard.Text = "Dashboard";
            // 
            // mnuRecipes
            // 
            this.mnuRecipes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecipeList,
            this.mnuRecipeInformation,
            this.mnuCloneRecipe});
            this.mnuRecipes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuRecipes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuRecipes.Name = "mnuRecipes";
            this.mnuRecipes.Size = new System.Drawing.Size(98, 32);
            this.mnuRecipes.Text = "Recipes";
            // 
            // mnuRecipeList
            // 
            this.mnuRecipeList.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuRecipeList.Name = "mnuRecipeList";
            this.mnuRecipeList.Size = new System.Drawing.Size(237, 32);
            this.mnuRecipeList.Text = "List";
            // 
            // mnuRecipeInformation
            // 
            this.mnuRecipeInformation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuRecipeInformation.Name = "mnuRecipeInformation";
            this.mnuRecipeInformation.Size = new System.Drawing.Size(237, 32);
            this.mnuRecipeInformation.Text = "New Recipe";
            // 
            // mnuCloneRecipe
            // 
            this.mnuCloneRecipe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuCloneRecipe.Name = "mnuCloneRecipe";
            this.mnuCloneRecipe.Size = new System.Drawing.Size(237, 32);
            this.mnuCloneRecipe.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            this.mnuMeals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMealList});
            this.mnuMeals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuMeals.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuMeals.Name = "mnuMeals";
            this.mnuMeals.Size = new System.Drawing.Size(82, 32);
            this.mnuMeals.Text = "Meals";
            // 
            // mnuMealList
            // 
            this.mnuMealList.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuMealList.Name = "mnuMealList";
            this.mnuMealList.Size = new System.Drawing.Size(131, 32);
            this.mnuMealList.Text = "List";
            // 
            // mnuCookbooks
            // 
            this.mnuCookbooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCookbookList,
            this.mnuCookbookInformation,
            this.mnuAutoCreateCookbook});
            this.mnuCookbooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuCookbooks.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuCookbooks.Name = "mnuCookbooks";
            this.mnuCookbooks.Size = new System.Drawing.Size(129, 32);
            this.mnuCookbooks.Text = "Cookbooks";
            // 
            // mnuCookbookList
            // 
            this.mnuCookbookList.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuCookbookList.Name = "mnuCookbookList";
            this.mnuCookbookList.Size = new System.Drawing.Size(241, 32);
            this.mnuCookbookList.Text = "List";
            // 
            // mnuCookbookInformation
            // 
            this.mnuCookbookInformation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuCookbookInformation.Name = "mnuCookbookInformation";
            this.mnuCookbookInformation.Size = new System.Drawing.Size(241, 32);
            this.mnuCookbookInformation.Text = "New Cookbook";
            // 
            // mnuAutoCreateCookbook
            // 
            this.mnuAutoCreateCookbook.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuAutoCreateCookbook.Name = "mnuAutoCreateCookbook";
            this.mnuAutoCreateCookbook.Size = new System.Drawing.Size(241, 32);
            this.mnuAutoCreateCookbook.Text = "Auto-Create";
            // 
            // mnuDataMaintenanceMain
            // 
            this.mnuDataMaintenanceMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataMaintenance});
            this.mnuDataMaintenanceMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuDataMaintenanceMain.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuDataMaintenanceMain.Name = "mnuDataMaintenanceMain";
            this.mnuDataMaintenanceMain.Size = new System.Drawing.Size(200, 32);
            this.mnuDataMaintenanceMain.Text = "Data Maintenance";
            // 
            // mnuDataMaintenance
            // 
            this.mnuDataMaintenance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuDataMaintenance.Name = "mnuDataMaintenance";
            this.mnuDataMaintenance.Size = new System.Drawing.Size(186, 32);
            this.mnuDataMaintenance.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            this.mnuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowsTile,
            this.mnuWindowsCascade});
            this.mnuWindows.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuWindows.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuWindows.Name = "mnuWindows";
            this.mnuWindows.Size = new System.Drawing.Size(113, 32);
            this.mnuWindows.Text = "Windows";
            // 
            // mnuWindowsTile
            // 
            this.mnuWindowsTile.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuWindowsTile.Name = "mnuWindowsTile";
            this.mnuWindowsTile.Size = new System.Drawing.Size(174, 32);
            this.mnuWindowsTile.Text = "Tile";
            // 
            // mnuWindowsCascade
            // 
            this.mnuWindowsCascade.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuWindowsCascade.Name = "mnuWindowsCascade";
            this.mnuWindowsCascade.Size = new System.Drawing.Size(174, 32);
            this.mnuWindowsCascade.Text = "Cascade";
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Location = new System.Drawing.Point(0, 38);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1054, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 624);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Recipe Apps";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStrip tsMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuRecipeInformation;
        private ToolStripMenuItem mnuCloneRecipe;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuCookbookInformation;
        private ToolStripMenuItem mnuAutoCreateCookbook;
        private ToolStripMenuItem mnuDataMaintenanceMain;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuWindows;
        private ToolStripMenuItem mnuWindowsTile;
        private ToolStripMenuItem mnuWindowsCascade;
    }
}