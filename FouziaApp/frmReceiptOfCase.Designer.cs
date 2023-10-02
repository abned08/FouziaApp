namespace FouziaApp
{
    partial class frmAddReceiptOfCase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddReceiptOfCase));
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.txtSearchRC = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.dtpRcDate = new MetroFramework.Controls.MetroDateTime();
            this.receiptOfCasetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRcName = new MetroFramework.Controls.MetroTextBox();
            this.btnDelete = new MetroFramework.Controls.MetroLink();
            this.btnAddToContext = new MetroFramework.Controls.MetroLink();
            this.addRC = new MetroFramework.Controls.MetroLink();
            this.dgvRC = new MetroFramework.Controls.MetroGrid();
            this.rcIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcJudicialAuthorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptOfCasetblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRC)).BeginInit();
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
            this.btnSave.Location = new System.Drawing.Point(216, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = global::FouziaApp.Properties.Resources.save;
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "حـــــــفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearchRC
            // 
            this.txtSearchRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearchRC.CustomButton.Image = null;
            this.txtSearchRC.CustomButton.Location = new System.Drawing.Point(525, 1);
            this.txtSearchRC.CustomButton.Name = "";
            this.txtSearchRC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchRC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchRC.CustomButton.TabIndex = 1;
            this.txtSearchRC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchRC.CustomButton.UseSelectable = true;
            this.txtSearchRC.CustomButton.Visible = false;
            this.txtSearchRC.DisplayIcon = true;
            this.txtSearchRC.Icon = global::FouziaApp.Properties.Resources.person;
            this.txtSearchRC.IconRight = true;
            this.txtSearchRC.Lines = new string[0];
            this.txtSearchRC.Location = new System.Drawing.Point(19, 159);
            this.txtSearchRC.MaxLength = 32767;
            this.txtSearchRC.Name = "txtSearchRC";
            this.txtSearchRC.PasswordChar = '\0';
            this.txtSearchRC.PromptText = "ابحث عن الجهة القضائية";
            this.txtSearchRC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchRC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchRC.SelectedText = "";
            this.txtSearchRC.SelectionLength = 0;
            this.txtSearchRC.SelectionStart = 0;
            this.txtSearchRC.ShortcutsEnabled = true;
            this.txtSearchRC.ShowClearButton = true;
            this.txtSearchRC.Size = new System.Drawing.Size(547, 23);
            this.txtSearchRC.Style = MetroFramework.MetroColorStyle.Black;
            this.txtSearchRC.TabIndex = 60;
            this.txtSearchRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchRC.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchRC.UseSelectable = true;
            this.txtSearchRC.WaterMark = "ابحث عن الجهة القضائية";
            this.txtSearchRC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchRC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchRC.TextChanged += new System.EventHandler(this.txtSearchRC_TextChanged);
            // 
            // metroPanel
            // 
            this.metroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel.Controls.Add(this.dtpRcDate);
            this.metroPanel.Controls.Add(this.txtRcName);
            this.metroPanel.Enabled = false;
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(128, 63);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(264, 90);
            this.metroPanel.TabIndex = 54;
            this.metroPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // dtpRcDate
            // 
            this.dtpRcDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRcDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receiptOfCasetblBindingSource, "rcDate", true));
            this.dtpRcDate.DisplayFocus = true;
            this.dtpRcDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpRcDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRcDate.Location = new System.Drawing.Point(3, 10);
            this.dtpRcDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpRcDate.Name = "dtpRcDate";
            this.dtpRcDate.Size = new System.Drawing.Size(254, 29);
            this.dtpRcDate.TabIndex = 5;
            this.dtpRcDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // receiptOfCasetblBindingSource
            // 
            this.receiptOfCasetblBindingSource.DataSource = typeof(FouziaApp.receiptOfCase_tbl);
            // 
            // txtRcName
            // 
            this.txtRcName.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtRcName.CustomButton.Image = null;
            this.txtRcName.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.txtRcName.CustomButton.Name = "";
            this.txtRcName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtRcName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRcName.CustomButton.TabIndex = 1;
            this.txtRcName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRcName.CustomButton.UseSelectable = true;
            this.txtRcName.CustomButton.Visible = false;
            this.txtRcName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptOfCasetblBindingSource, "rcJudicialAuthority", true));
            this.txtRcName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRcName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtRcName.Lines = new string[0];
            this.txtRcName.Location = new System.Drawing.Point(3, 51);
            this.txtRcName.MaxLength = 32767;
            this.txtRcName.Name = "txtRcName";
            this.txtRcName.PasswordChar = '\0';
            this.txtRcName.PromptText = "الجهة القضائية";
            this.txtRcName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRcName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRcName.SelectedText = "";
            this.txtRcName.SelectionLength = 0;
            this.txtRcName.SelectionStart = 0;
            this.txtRcName.ShortcutsEnabled = true;
            this.txtRcName.Size = new System.Drawing.Size(254, 35);
            this.txtRcName.TabIndex = 1;
            this.txtRcName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRcName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRcName.UseSelectable = true;
            this.txtRcName.WaterMark = "الجهة القضائية";
            this.txtRcName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRcName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Image = global::FouziaApp.Properties.Resources.delete;
            this.btnDelete.ImageSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(86, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoFocusImage = global::FouziaApp.Properties.Resources.delete;
            this.btnDelete.Size = new System.Drawing.Size(36, 32);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDelete.TabIndex = 59;
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
            this.btnAddToContext.Location = new System.Drawing.Point(44, 92);
            this.btnAddToContext.Name = "btnAddToContext";
            this.btnAddToContext.NoFocusImage = global::FouziaApp.Properties.Resources.check;
            this.btnAddToContext.Size = new System.Drawing.Size(36, 32);
            this.btnAddToContext.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAddToContext.TabIndex = 55;
            this.btnAddToContext.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddToContext.UseSelectable = true;
            this.btnAddToContext.Click += new System.EventHandler(this.btnAddToContext_Click);
            // 
            // addRC
            // 
            this.addRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addRC.Image = global::FouziaApp.Properties.Resources.plus1;
            this.addRC.ImageSize = 25;
            this.addRC.Location = new System.Drawing.Point(356, 37);
            this.addRC.Name = "addRC";
            this.addRC.NoFocusImage = global::FouziaApp.Properties.Resources.plus1;
            this.addRC.Size = new System.Drawing.Size(36, 32);
            this.addRC.Style = MetroFramework.MetroColorStyle.Green;
            this.addRC.TabIndex = 58;
            this.addRC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addRC.UseSelectable = true;
            this.addRC.Click += new System.EventHandler(this.addRC_Click);
            // 
            // dgvRC
            // 
            this.dgvRC.AllowUserToAddRows = false;
            this.dgvRC.AllowUserToDeleteRows = false;
            this.dgvRC.AllowUserToResizeRows = false;
            this.dgvRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRC.AutoGenerateColumns = false;
            this.dgvRC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvRC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rcIDDataGridViewTextBoxColumn,
            this.rcDateDataGridViewTextBoxColumn,
            this.rcJudicialAuthorityDataGridViewTextBoxColumn});
            this.dgvRC.DataSource = this.receiptOfCasetblBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRC.EnableHeadersVisualStyles = false;
            this.dgvRC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvRC.Location = new System.Drawing.Point(19, 188);
            this.dgvRC.MultiSelect = false;
            this.dgvRC.Name = "dgvRC";
            this.dgvRC.ReadOnly = true;
            this.dgvRC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvRC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRC.Size = new System.Drawing.Size(547, 296);
            this.dgvRC.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvRC.TabIndex = 57;
            this.dgvRC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvRC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRC_CellClick);
            // 
            // rcIDDataGridViewTextBoxColumn
            // 
            this.rcIDDataGridViewTextBoxColumn.DataPropertyName = "rcID";
            this.rcIDDataGridViewTextBoxColumn.HeaderText = "rcID";
            this.rcIDDataGridViewTextBoxColumn.Name = "rcIDDataGridViewTextBoxColumn";
            this.rcIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rcIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rcDateDataGridViewTextBoxColumn
            // 
            this.rcDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rcDateDataGridViewTextBoxColumn.DataPropertyName = "rcDate";
            this.rcDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الاستلام";
            this.rcDateDataGridViewTextBoxColumn.Name = "rcDateDataGridViewTextBoxColumn";
            this.rcDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rcJudicialAuthorityDataGridViewTextBoxColumn
            // 
            this.rcJudicialAuthorityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rcJudicialAuthorityDataGridViewTextBoxColumn.DataPropertyName = "rcJudicialAuthority";
            this.rcJudicialAuthorityDataGridViewTextBoxColumn.HeaderText = "الجهة القضائية";
            this.rcJudicialAuthorityDataGridViewTextBoxColumn.Name = "rcJudicialAuthorityDataGridViewTextBoxColumn";
            this.rcJudicialAuthorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(398, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(171, 25);
            this.metroLabel2.TabIndex = 56;
            this.metroLabel2.Text = ": تاريخ استلام القضية";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(398, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 25);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = ": الجهة القضائية";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmAddReceiptOfCase
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 546);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSearchRC);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddToContext);
            this.Controls.Add(this.addRC);
            this.Controls.Add(this.dgvRC);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddReceiptOfCase";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "إضافة (تعديل) الجهة القضائية";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmReceiptOfCase_Load);
            this.metroPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptOfCasetblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroTextBox txtSearchRC;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroTextBox txtRcName;
        private MetroFramework.Controls.MetroLink btnDelete;
        private MetroFramework.Controls.MetroLink btnAddToContext;
        private MetroFramework.Controls.MetroLink addRC;
        private MetroFramework.Controls.MetroGrid dgvRC;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtpRcDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource receiptOfCasetblBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcJudicialAuthorityDataGridViewTextBoxColumn;
    }
}