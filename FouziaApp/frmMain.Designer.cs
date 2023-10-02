namespace FouziaApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mtBeforeDisputes = new MetroFramework.Controls.MetroTile();
            this.mtdisputes = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.partiesToTheConflicttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caseSubjecttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partiesToTheConflicttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseSubjecttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personstblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel3.UseStyleColors = true;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // mtPanel
            // 
            resources.ApplyResources(this.mtPanel, "mtPanel");
            this.mtPanel.HorizontalScrollbarBarColor = true;
            this.mtPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mtPanel.HorizontalScrollbarSize = 10;
            this.mtPanel.Name = "mtPanel";
            this.mtPanel.VerticalScrollbarBarColor = true;
            this.mtPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mtPanel.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.Controls.Add(this.mtBeforeDisputes);
            this.metroPanel1.Controls.Add(this.mtdisputes);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mtBeforeDisputes
            // 
            this.mtBeforeDisputes.ActiveControl = null;
            resources.ApplyResources(this.mtBeforeDisputes, "mtBeforeDisputes");
            this.mtBeforeDisputes.Name = "mtBeforeDisputes";
            this.mtBeforeDisputes.TileImage = global::FouziaApp.Properties.Resources.beforDespute1;
            this.mtBeforeDisputes.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtBeforeDisputes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtBeforeDisputes.UseSelectable = true;
            this.mtBeforeDisputes.UseTileImage = true;
            this.mtBeforeDisputes.Click += new System.EventHandler(this.mtBeforeDisputes_Click);
            // 
            // mtdisputes
            // 
            this.mtdisputes.ActiveControl = null;
            resources.ApplyResources(this.mtdisputes, "mtdisputes");
            this.mtdisputes.Name = "mtdisputes";
            this.mtdisputes.Style = MetroFramework.MetroColorStyle.Green;
            this.mtdisputes.TileImage = global::FouziaApp.Properties.Resources.land2;
            this.mtdisputes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtdisputes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtdisputes.UseSelectable = true;
            this.mtdisputes.UseTileImage = true;
            this.mtdisputes.Click += new System.EventHandler(this.mtdisputes_Click);
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            resources.ApplyResources(this.metroLabel5, "metroLabel5");
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // partiesToTheConflicttblBindingSource
            // 
            this.partiesToTheConflicttblBindingSource.DataSource = typeof(FouziaApp.partiesToTheConflict_tbl);
            // 
            // caseSubjecttblBindingSource
            // 
            this.caseSubjecttblBindingSource.DataSource = typeof(FouziaApp.caseSubject_tbl);
            // 
            // personstblBindingSource
            // 
            this.personstblBindingSource.DataSource = typeof(FouziaApp.persons_tbl);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.mtPanel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Main_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partiesToTheConflicttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseSubjecttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personstblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel mtPanel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile mtBeforeDisputes;
        private MetroFramework.Controls.MetroTile mtdisputes;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.BindingSource personstblBindingSource;
        private System.Windows.Forms.BindingSource partiesToTheConflicttblBindingSource;
        private System.Windows.Forms.BindingSource caseSubjecttblBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}

