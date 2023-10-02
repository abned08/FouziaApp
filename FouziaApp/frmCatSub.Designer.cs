namespace FouziaApp
{
    partial class frmAddCatSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCatSub));
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.txtCatSub = new MetroFramework.Controls.MetroTextBox();
            this.catSubtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new MetroFramework.Controls.MetroLink();
            this.btnAddToContext = new MetroFramework.Controls.MetroLink();
            this.addCatSub = new MetroFramework.Controls.MetroLink();
            this.dgvCatSub = new MetroFramework.Controls.MetroGrid();
            this.catSubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catSubNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchCatSub = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catSubtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatSub)).BeginInit();
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
            this.btnSave.Location = new System.Drawing.Point(224, 485);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "حـــــــفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroPanel
            // 
            this.metroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel.Controls.Add(this.txtCatSub);
            this.metroPanel.Enabled = false;
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(97, 103);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(463, 42);
            this.metroPanel.TabIndex = 40;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // txtCatSub
            // 
            this.txtCatSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtCatSub.CustomButton.Image = null;
            this.txtCatSub.CustomButton.Location = new System.Drawing.Point(423, 1);
            this.txtCatSub.CustomButton.Name = "";
            this.txtCatSub.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtCatSub.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCatSub.CustomButton.TabIndex = 1;
            this.txtCatSub.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCatSub.CustomButton.UseSelectable = true;
            this.txtCatSub.CustomButton.Visible = false;
            this.txtCatSub.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.catSubtblBindingSource, "catSubName", true));
            this.txtCatSub.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCatSub.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCatSub.Lines = new string[0];
            this.txtCatSub.Location = new System.Drawing.Point(3, 3);
            this.txtCatSub.MaxLength = 32767;
            this.txtCatSub.Name = "txtCatSub";
            this.txtCatSub.PasswordChar = '\0';
            this.txtCatSub.PromptText = "صنف موضوع القضية";
            this.txtCatSub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCatSub.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCatSub.SelectedText = "";
            this.txtCatSub.SelectionLength = 0;
            this.txtCatSub.SelectionStart = 0;
            this.txtCatSub.ShortcutsEnabled = true;
            this.txtCatSub.Size = new System.Drawing.Size(457, 35);
            this.txtCatSub.TabIndex = 1;
            this.txtCatSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCatSub.UseSelectable = true;
            this.txtCatSub.WaterMark = "صنف موضوع القضية";
            this.txtCatSub.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCatSub.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // catSubtblBindingSource
            // 
            this.catSubtblBindingSource.DataSource = typeof(FouziaApp.catSub_tbl);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Image = global::FouziaApp.Properties.Resources.delete;
            this.btnDelete.ImageSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(55, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 32);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDelete.TabIndex = 45;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddToContext
            // 
            this.btnAddToContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToContext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddToContext.Image = global::FouziaApp.Properties.Resources.check;
            this.btnAddToContext.ImageSize = 30;
            this.btnAddToContext.Location = new System.Drawing.Point(13, 106);
            this.btnAddToContext.Name = "btnAddToContext";
            this.btnAddToContext.Size = new System.Drawing.Size(36, 32);
            this.btnAddToContext.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAddToContext.TabIndex = 41;
            this.btnAddToContext.UseSelectable = true;
            this.btnAddToContext.Click += new System.EventHandler(this.btnAddToContext_Click);
            // 
            // addCatSub
            // 
            this.addCatSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addCatSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addCatSub.Image = global::FouziaApp.Properties.Resources.plus1;
            this.addCatSub.ImageSize = 25;
            this.addCatSub.Location = new System.Drawing.Point(456, 62);
            this.addCatSub.Name = "addCatSub";
            this.addCatSub.Size = new System.Drawing.Size(36, 32);
            this.addCatSub.Style = MetroFramework.MetroColorStyle.Green;
            this.addCatSub.TabIndex = 44;
            this.addCatSub.UseSelectable = true;
            this.addCatSub.Click += new System.EventHandler(this.addCatSub_Click);
            // 
            // dgvCatSub
            // 
            this.dgvCatSub.AllowUserToAddRows = false;
            this.dgvCatSub.AllowUserToDeleteRows = false;
            this.dgvCatSub.AllowUserToResizeRows = false;
            this.dgvCatSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatSub.AutoGenerateColumns = false;
            this.dgvCatSub.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCatSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatSub.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCatSub.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catSubIDDataGridViewTextBoxColumn,
            this.catSubNameDataGridViewTextBoxColumn});
            this.dgvCatSub.DataSource = this.catSubtblBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatSub.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatSub.EnableHeadersVisualStyles = false;
            this.dgvCatSub.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCatSub.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCatSub.Location = new System.Drawing.Point(13, 180);
            this.dgvCatSub.MultiSelect = false;
            this.dgvCatSub.Name = "dgvCatSub";
            this.dgvCatSub.ReadOnly = true;
            this.dgvCatSub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCatSub.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatSub.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatSub.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCatSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatSub.Size = new System.Drawing.Size(547, 296);
            this.dgvCatSub.TabIndex = 43;
            this.dgvCatSub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatSub_CellClick);
            // 
            // catSubIDDataGridViewTextBoxColumn
            // 
            this.catSubIDDataGridViewTextBoxColumn.DataPropertyName = "catSubID";
            this.catSubIDDataGridViewTextBoxColumn.HeaderText = "catSubID";
            this.catSubIDDataGridViewTextBoxColumn.Name = "catSubIDDataGridViewTextBoxColumn";
            this.catSubIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.catSubIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // catSubNameDataGridViewTextBoxColumn
            // 
            this.catSubNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catSubNameDataGridViewTextBoxColumn.DataPropertyName = "catSubName";
            this.catSubNameDataGridViewTextBoxColumn.HeaderText = "صنف موضوع القضية";
            this.catSubNameDataGridViewTextBoxColumn.Name = "catSubNameDataGridViewTextBoxColumn";
            this.catSubNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(265, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(185, 25);
            this.metroLabel2.TabIndex = 42;
            this.metroLabel2.Text = ": صنف موضوع القضية";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchCatSub
            // 
            this.txtSearchCatSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearchCatSub.CustomButton.Image = null;
            this.txtSearchCatSub.CustomButton.Location = new System.Drawing.Point(525, 1);
            this.txtSearchCatSub.CustomButton.Name = "";
            this.txtSearchCatSub.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchCatSub.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchCatSub.CustomButton.TabIndex = 1;
            this.txtSearchCatSub.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchCatSub.CustomButton.UseSelectable = true;
            this.txtSearchCatSub.CustomButton.Visible = false;
            this.txtSearchCatSub.DisplayIcon = true;
            this.txtSearchCatSub.Icon = global::FouziaApp.Properties.Resources.person;
            this.txtSearchCatSub.IconRight = true;
            this.txtSearchCatSub.Lines = new string[0];
            this.txtSearchCatSub.Location = new System.Drawing.Point(13, 151);
            this.txtSearchCatSub.MaxLength = 32767;
            this.txtSearchCatSub.Name = "txtSearchCatSub";
            this.txtSearchCatSub.PasswordChar = '\0';
            this.txtSearchCatSub.PromptText = "ابحث عن صنف";
            this.txtSearchCatSub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchCatSub.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchCatSub.SelectedText = "";
            this.txtSearchCatSub.SelectionLength = 0;
            this.txtSearchCatSub.SelectionStart = 0;
            this.txtSearchCatSub.ShortcutsEnabled = true;
            this.txtSearchCatSub.ShowClearButton = true;
            this.txtSearchCatSub.Size = new System.Drawing.Size(547, 23);
            this.txtSearchCatSub.Style = MetroFramework.MetroColorStyle.Black;
            this.txtSearchCatSub.TabIndex = 46;
            this.txtSearchCatSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchCatSub.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchCatSub.UseSelectable = true;
            this.txtSearchCatSub.WaterMark = "ابحث عن صنف";
            this.txtSearchCatSub.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchCatSub.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchCatSub.TextChanged += new System.EventHandler(this.txtSearchCatSub_TextChanged);
            // 
            // frmAddCatSub
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 543);
            this.Controls.Add(this.txtSearchCatSub);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddToContext);
            this.Controls.Add(this.addCatSub);
            this.Controls.Add(this.dgvCatSub);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddCatSub";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "إضافة (تعديل) صنف موضوع القضية";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmCatSub_Load);
            this.metroPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catSubtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroTextBox txtCatSub;
        private MetroFramework.Controls.MetroLink btnDelete;
        private MetroFramework.Controls.MetroLink btnAddToContext;
        private MetroFramework.Controls.MetroLink addCatSub;
        private MetroFramework.Controls.MetroGrid dgvCatSub;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtSearchCatSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn catSubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catSubNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource catSubtblBindingSource;
    }
}