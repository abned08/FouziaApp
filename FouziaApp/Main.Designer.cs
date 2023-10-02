namespace FouziaApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtPanel = new MetroFramework.Controls.MetroPanel();
            this.mtBeforeDisputes = new MetroFramework.Controls.MetroTile();
            this.mtdisputes = new MetroFramework.Controls.MetroTile();
            this.mtBack = new MetroFramework.Controls.MetroLink();
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
            // mtBack
            // 
            this.mtBack.DisplayFocus = true;
            this.mtBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mtBack.Image = global::FouziaApp.Properties.Resources.back1;
            this.mtBack.ImageSize = 40;
            resources.ApplyResources(this.mtBack, "mtBack");
            this.mtBack.Name = "mtBack";
            this.mtBack.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtBack.UseCustomBackColor = true;
            this.mtBack.UseCustomForeColor = true;
            this.mtBack.UseSelectable = true;
            this.mtBack.UseStyleColors = true;
            this.mtBack.Click += new System.EventHandler(this.mtBack_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtBeforeDisputes);
            this.Controls.Add(this.mtPanel);
            this.Controls.Add(this.mtdisputes);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLink mtBack;
        private MetroFramework.Controls.MetroPanel mtPanel;
        private MetroFramework.Controls.MetroTile mtBeforeDisputes;
        private MetroFramework.Controls.MetroTile mtdisputes;
    }
}

