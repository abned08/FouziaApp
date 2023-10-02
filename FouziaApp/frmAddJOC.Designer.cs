namespace FouziaApp
{
    partial class frmAddJOC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.txtSearchJOC = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.txtJOC = new MetroFramework.Controls.MetroTextBox();
            this.judgmentOnTheCasetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new MetroFramework.Controls.MetroLink();
            this.btnAddToContext = new MetroFramework.Controls.MetroLink();
            this.addJOC = new MetroFramework.Controls.MetroLink();
            this.dgvJOC = new MetroFramework.Controls.MetroGrid();
            this.jOCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.judgmentOnTheCasetblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJOC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnSave.Image = global::FouziaApp.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageSize = 45;
            this.btnSave.Location = new System.Drawing.Point(227, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = global::FouziaApp.Properties.Resources.save;
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "حـــــــفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearchJOC
            // 
            this.txtSearchJOC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearchJOC.CustomButton.Image = null;
            this.txtSearchJOC.CustomButton.Location = new System.Drawing.Point(525, 1);
            this.txtSearchJOC.CustomButton.Name = "";
            this.txtSearchJOC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchJOC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchJOC.CustomButton.TabIndex = 1;
            this.txtSearchJOC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchJOC.CustomButton.UseSelectable = true;
            this.txtSearchJOC.CustomButton.Visible = false;
            this.txtSearchJOC.DisplayIcon = true;
            this.txtSearchJOC.Icon = global::FouziaApp.Properties.Resources.person;
            this.txtSearchJOC.IconRight = true;
            this.txtSearchJOC.Lines = new string[0];
            this.txtSearchJOC.Location = new System.Drawing.Point(21, 146);
            this.txtSearchJOC.MaxLength = 32767;
            this.txtSearchJOC.Name = "txtSearchJOC";
            this.txtSearchJOC.PasswordChar = '\0';
            this.txtSearchJOC.PromptText = "ابحث عن الحكم الصادر";
            this.txtSearchJOC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchJOC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchJOC.SelectedText = "";
            this.txtSearchJOC.SelectionLength = 0;
            this.txtSearchJOC.SelectionStart = 0;
            this.txtSearchJOC.ShortcutsEnabled = true;
            this.txtSearchJOC.ShowClearButton = true;
            this.txtSearchJOC.Size = new System.Drawing.Size(547, 23);
            this.txtSearchJOC.Style = MetroFramework.MetroColorStyle.Black;
            this.txtSearchJOC.TabIndex = 53;
            this.txtSearchJOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchJOC.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchJOC.UseSelectable = true;
            this.txtSearchJOC.WaterMark = "ابحث عن الحكم الصادر";
            this.txtSearchJOC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchJOC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchJOC.TextChanged += new System.EventHandler(this.txtSearchJOC_TextChanged);
            // 
            // metroPanel
            // 
            this.metroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel.Controls.Add(this.txtJOC);
            this.metroPanel.Enabled = false;
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(105, 98);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(463, 42);
            this.metroPanel.TabIndex = 47;
            this.metroPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // txtJOC
            // 
            this.txtJOC.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtJOC.CustomButton.Image = null;
            this.txtJOC.CustomButton.Location = new System.Drawing.Point(423, 1);
            this.txtJOC.CustomButton.Name = "";
            this.txtJOC.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtJOC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJOC.CustomButton.TabIndex = 1;
            this.txtJOC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJOC.CustomButton.UseSelectable = true;
            this.txtJOC.CustomButton.Visible = false;
            this.txtJOC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.judgmentOnTheCasetblBindingSource, "JOCName", true));
            this.txtJOC.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtJOC.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtJOC.Lines = new string[0];
            this.txtJOC.Location = new System.Drawing.Point(3, 3);
            this.txtJOC.MaxLength = 32767;
            this.txtJOC.Name = "txtJOC";
            this.txtJOC.PasswordChar = '\0';
            this.txtJOC.PromptText = "الحكم الصادر بشأن القضية";
            this.txtJOC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtJOC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJOC.SelectedText = "";
            this.txtJOC.SelectionLength = 0;
            this.txtJOC.SelectionStart = 0;
            this.txtJOC.ShortcutsEnabled = true;
            this.txtJOC.Size = new System.Drawing.Size(457, 35);
            this.txtJOC.TabIndex = 1;
            this.txtJOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJOC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtJOC.UseSelectable = true;
            this.txtJOC.WaterMark = "الحكم الصادر بشأن القضية";
            this.txtJOC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJOC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // judgmentOnTheCasetblBindingSource
            // 
            this.judgmentOnTheCasetblBindingSource.DataSource = typeof(FouziaApp.judgmentOnTheCase_tbl);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Image = global::FouziaApp.Properties.Resources.delete;
            this.btnDelete.ImageSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(63, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoFocusImage = global::FouziaApp.Properties.Resources.delete;
            this.btnDelete.Size = new System.Drawing.Size(36, 32);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddToContext
            // 
            this.btnAddToContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToContext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddToContext.Image = global::FouziaApp.Properties.Resources.check;
            this.btnAddToContext.ImageSize = 30;
            this.btnAddToContext.Location = new System.Drawing.Point(21, 101);
            this.btnAddToContext.Name = "btnAddToContext";
            this.btnAddToContext.NoFocusImage = global::FouziaApp.Properties.Resources.check;
            this.btnAddToContext.Size = new System.Drawing.Size(36, 32);
            this.btnAddToContext.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAddToContext.TabIndex = 48;
            this.btnAddToContext.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddToContext.UseSelectable = true;
            this.btnAddToContext.Click += new System.EventHandler(this.btnAddToContext_Click);
            // 
            // addJOC
            // 
            this.addJOC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addJOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addJOC.Image = global::FouziaApp.Properties.Resources.plus1;
            this.addJOC.ImageSize = 25;
            this.addJOC.Location = new System.Drawing.Point(464, 57);
            this.addJOC.Name = "addJOC";
            this.addJOC.NoFocusImage = global::FouziaApp.Properties.Resources.plus1;
            this.addJOC.Size = new System.Drawing.Size(36, 32);
            this.addJOC.Style = MetroFramework.MetroColorStyle.Green;
            this.addJOC.TabIndex = 51;
            this.addJOC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addJOC.UseSelectable = true;
            this.addJOC.Click += new System.EventHandler(this.addJOC_Click);
            // 
            // dgvJOC
            // 
            this.dgvJOC.AllowUserToAddRows = false;
            this.dgvJOC.AllowUserToDeleteRows = false;
            this.dgvJOC.AllowUserToResizeRows = false;
            this.dgvJOC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJOC.AutoGenerateColumns = false;
            this.dgvJOC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvJOC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJOC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvJOC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJOC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJOC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jOCIDDataGridViewTextBoxColumn,
            this.jOCNameDataGridViewTextBoxColumn});
            this.dgvJOC.DataSource = this.judgmentOnTheCasetblBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJOC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJOC.EnableHeadersVisualStyles = false;
            this.dgvJOC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvJOC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvJOC.Location = new System.Drawing.Point(21, 175);
            this.dgvJOC.MultiSelect = false;
            this.dgvJOC.Name = "dgvJOC";
            this.dgvJOC.ReadOnly = true;
            this.dgvJOC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvJOC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJOC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJOC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJOC.Size = new System.Drawing.Size(547, 296);
            this.dgvJOC.TabIndex = 50;
            this.dgvJOC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvJOC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJOC_CellClick);
            // 
            // jOCIDDataGridViewTextBoxColumn
            // 
            this.jOCIDDataGridViewTextBoxColumn.DataPropertyName = "JOCID";
            this.jOCIDDataGridViewTextBoxColumn.HeaderText = "JOCID";
            this.jOCIDDataGridViewTextBoxColumn.Name = "jOCIDDataGridViewTextBoxColumn";
            this.jOCIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.jOCIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // jOCNameDataGridViewTextBoxColumn
            // 
            this.jOCNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jOCNameDataGridViewTextBoxColumn.DataPropertyName = "JOCName";
            this.jOCNameDataGridViewTextBoxColumn.HeaderText = "الحكم الصادر بشأن القضية";
            this.jOCNameDataGridViewTextBoxColumn.Name = "jOCNameDataGridViewTextBoxColumn";
            this.jOCNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(237, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(221, 25);
            this.metroLabel2.TabIndex = 49;
            this.metroLabel2.Text = ": الحكم الصادر بشأن القضية";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmAddJOC
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 578);
            this.Controls.Add(this.txtSearchJOC);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddToContext);
            this.Controls.Add(this.addJOC);
            this.Controls.Add(this.dgvJOC);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "frmAddJOC";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "إضافة (تعديل) الحكم الصادر بشأن القضية";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmAddJOC_Load);
            this.metroPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.judgmentOnTheCasetblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJOC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroTextBox txtSearchJOC;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroTextBox txtJOC;
        private MetroFramework.Controls.MetroLink btnDelete;
        private MetroFramework.Controls.MetroLink btnAddToContext;
        private MetroFramework.Controls.MetroLink addJOC;
        private MetroFramework.Controls.MetroGrid dgvJOC;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource judgmentOnTheCasetblBindingSource;
    }
}