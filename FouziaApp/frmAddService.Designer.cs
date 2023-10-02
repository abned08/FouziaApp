namespace FouziaApp
{
    partial class frmAddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddService));
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchService = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.txtServiceName = new MetroFramework.Controls.MetroTextBox();
            this.servicetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new MetroFramework.Controls.MetroLink();
            this.btnAddToContext = new MetroFramework.Controls.MetroLink();
            this.addService = new MetroFramework.Controls.MetroLink();
            this.dgvService = new MetroFramework.Controls.MetroGrid();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicetblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
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
            this.btnSave.Location = new System.Drawing.Point(222, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = global::FouziaApp.Properties.Resources.save;
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "حـــــــفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(401, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = ": المصلحــــة";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtSearchService
            // 
            this.txtSearchService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearchService.CustomButton.Image = null;
            this.txtSearchService.CustomButton.Location = new System.Drawing.Point(525, 1);
            this.txtSearchService.CustomButton.Name = "";
            this.txtSearchService.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchService.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchService.CustomButton.TabIndex = 1;
            this.txtSearchService.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchService.CustomButton.UseSelectable = true;
            this.txtSearchService.CustomButton.Visible = false;
            this.txtSearchService.DisplayIcon = true;
            this.txtSearchService.Icon = global::FouziaApp.Properties.Resources.person;
            this.txtSearchService.IconRight = true;
            this.txtSearchService.Lines = new string[0];
            this.txtSearchService.Location = new System.Drawing.Point(21, 154);
            this.txtSearchService.MaxLength = 32767;
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.PasswordChar = '\0';
            this.txtSearchService.PromptText = "ابحث عن المصلحــــــة";
            this.txtSearchService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchService.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchService.SelectedText = "";
            this.txtSearchService.SelectionLength = 0;
            this.txtSearchService.SelectionStart = 0;
            this.txtSearchService.ShortcutsEnabled = true;
            this.txtSearchService.ShowClearButton = true;
            this.txtSearchService.Size = new System.Drawing.Size(547, 23);
            this.txtSearchService.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtSearchService.TabIndex = 68;
            this.txtSearchService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchService.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchService.UseSelectable = true;
            this.txtSearchService.WaterMark = "ابحث عن المصلحــــــة";
            this.txtSearchService.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchService.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchService.TextChanged += new System.EventHandler(this.txtSearchService_TextChanged);
            // 
            // metroPanel
            // 
            this.metroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel.Controls.Add(this.txtServiceName);
            this.metroPanel.Enabled = false;
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(131, 104);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(264, 39);
            this.metroPanel.TabIndex = 62;
            this.metroPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtServiceName.CustomButton.Image = null;
            this.txtServiceName.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.txtServiceName.CustomButton.Name = "";
            this.txtServiceName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtServiceName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServiceName.CustomButton.TabIndex = 1;
            this.txtServiceName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServiceName.CustomButton.UseSelectable = true;
            this.txtServiceName.CustomButton.Visible = false;
            this.txtServiceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicetblBindingSource, "serviceName", true));
            this.txtServiceName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtServiceName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtServiceName.Lines = new string[0];
            this.txtServiceName.Location = new System.Drawing.Point(4, 2);
            this.txtServiceName.MaxLength = 32767;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PasswordChar = '\0';
            this.txtServiceName.PromptText = "المصلحــــة";
            this.txtServiceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtServiceName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.SelectionLength = 0;
            this.txtServiceName.SelectionStart = 0;
            this.txtServiceName.ShortcutsEnabled = true;
            this.txtServiceName.Size = new System.Drawing.Size(254, 35);
            this.txtServiceName.TabIndex = 1;
            this.txtServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtServiceName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtServiceName.UseSelectable = true;
            this.txtServiceName.WaterMark = "المصلحــــة";
            this.txtServiceName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServiceName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // servicetblBindingSource
            // 
            this.servicetblBindingSource.DataSource = typeof(FouziaApp.service_tbl);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Image = global::FouziaApp.Properties.Resources.delete;
            this.btnDelete.ImageSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(88, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoFocusImage = global::FouziaApp.Properties.Resources.delete;
            this.btnDelete.Size = new System.Drawing.Size(36, 32);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDelete.TabIndex = 67;
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
            this.btnAddToContext.Location = new System.Drawing.Point(46, 104);
            this.btnAddToContext.Name = "btnAddToContext";
            this.btnAddToContext.NoFocusImage = global::FouziaApp.Properties.Resources.check;
            this.btnAddToContext.Size = new System.Drawing.Size(36, 32);
            this.btnAddToContext.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAddToContext.TabIndex = 63;
            this.btnAddToContext.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddToContext.UseSelectable = true;
            this.btnAddToContext.Click += new System.EventHandler(this.btnAddToContext_Click);
            // 
            // addService
            // 
            this.addService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addService.Image = global::FouziaApp.Properties.Resources.plus1;
            this.addService.ImageSize = 25;
            this.addService.Location = new System.Drawing.Point(358, 78);
            this.addService.Name = "addService";
            this.addService.NoFocusImage = global::FouziaApp.Properties.Resources.plus1;
            this.addService.Size = new System.Drawing.Size(36, 32);
            this.addService.Style = MetroFramework.MetroColorStyle.Green;
            this.addService.TabIndex = 66;
            this.addService.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addService.UseSelectable = true;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.AllowUserToResizeRows = false;
            this.dgvService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvService.AutoGenerateColumns = false;
            this.dgvService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvService.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn});
            this.dgvService.DataSource = this.servicetblBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvService.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvService.EnableHeadersVisualStyles = false;
            this.dgvService.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvService.Location = new System.Drawing.Point(21, 183);
            this.dgvService.MultiSelect = false;
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvService.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvService.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvService.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvService.Size = new System.Drawing.Size(547, 296);
            this.dgvService.Style = MetroFramework.MetroColorStyle.Lime;
            this.dgvService.TabIndex = 65;
            this.dgvService.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellClick);
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "serviceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "المصلحـــــــة";
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmAddService
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 552);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSearchService);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddToContext);
            this.Controls.Add(this.addService);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddService";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "إضافة (تعديل) مصلحـــــة";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmAddService_Load);
            this.metroPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicetblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSearchService;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroTextBox txtServiceName;
        private MetroFramework.Controls.MetroLink btnDelete;
        private MetroFramework.Controls.MetroLink btnAddToContext;
        private MetroFramework.Controls.MetroLink addService;
        private MetroFramework.Controls.MetroGrid dgvService;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource servicetblBindingSource;
    }
}