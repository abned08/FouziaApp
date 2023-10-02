namespace FouziaApp
{
    partial class ucDisputes
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

        #region Component Designer generated code

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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtdgvPerson = new MetroFramework.Controls.MetroGrid();
            this.الشخص = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseSubject_tbl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csIlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStatistics = new MetroFramework.Controls.MetroLink();
            this.addPerson = new MetroFramework.Controls.MetroLink();
            this.addCaseSubj = new MetroFramework.Controls.MetroLink();
            this.txtPerson = new MetroFramework.Controls.MetroTextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.caseSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partiesToTheConflicttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mtdgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personstblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesToTheConflicttblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(746, 17);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(168, 47);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "البحث عن الشخص\r\n أو موضوع القضية";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "caseSubject_tbl";
            this.dataGridViewTextBoxColumn1.HeaderText = "caseSubject_tbl";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "partiesToTheConflict_tbl";
            this.dataGridViewTextBoxColumn2.HeaderText = "partiesToTheConflict_tbl";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "caseSubject_tbl";
            this.dataGridViewTextBoxColumn3.HeaderText = "caseSubject_tbl";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "partiesToTheConflict_tbl";
            this.dataGridViewTextBoxColumn4.HeaderText = "partiesToTheConflict_tbl";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // mtdgvPerson
            // 
            this.mtdgvPerson.AllowUserToAddRows = false;
            this.mtdgvPerson.AllowUserToDeleteRows = false;
            this.mtdgvPerson.AllowUserToResizeRows = false;
            this.mtdgvPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtdgvPerson.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtdgvPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtdgvPerson.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mtdgvPerson.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtdgvPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mtdgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mtdgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.الشخص,
            this.Column1,
            this.caseSubject_tbl,
            this.Column2,
            this.csIlot,
            this.csLot,
            this.csTown});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtdgvPerson.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtdgvPerson.EnableHeadersVisualStyles = false;
            this.mtdgvPerson.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtdgvPerson.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtdgvPerson.Location = new System.Drawing.Point(4, 76);
            this.mtdgvPerson.Margin = new System.Windows.Forms.Padding(4);
            this.mtdgvPerson.MultiSelect = false;
            this.mtdgvPerson.Name = "mtdgvPerson";
            this.mtdgvPerson.ReadOnly = true;
            this.mtdgvPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtdgvPerson.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtdgvPerson.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mtdgvPerson.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mtdgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mtdgvPerson.ShowCellToolTips = false;
            this.mtdgvPerson.Size = new System.Drawing.Size(983, 369);
            this.mtdgvPerson.Style = MetroFramework.MetroColorStyle.Green;
            this.mtdgvPerson.TabIndex = 4;
            this.metroToolTip1.SetToolTip(this.mtdgvPerson, "لتعديل موضوع القضية اضغط على الزر يمين الفأرة");
            this.mtdgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mtdgvPerson_CellClick);
            this.mtdgvPerson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mtdgvPerson_CellDoubleClick);
            this.mtdgvPerson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtdgvPerson_KeyDown);
            this.mtdgvPerson.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mtdgvPerson_MouseUp);
            // 
            // الشخص
            // 
            this.الشخص.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.الشخص.DataPropertyName = "personName";
            this.الشخص.HeaderText = "الشخص";
            this.الشخص.Name = "الشخص";
            this.الشخص.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "PTCName";
            this.Column1.HeaderText = "مدخلية الخصام";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 119;
            // 
            // caseSubject_tbl
            // 
            this.caseSubject_tbl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.caseSubject_tbl.DataPropertyName = "csAdress";
            this.caseSubject_tbl.HeaderText = "موضوع القضية";
            this.caseSubject_tbl.Name = "caseSubject_tbl";
            this.caseSubject_tbl.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "csSec";
            this.Column2.HeaderText = "القسم";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 68;
            // 
            // csIlot
            // 
            this.csIlot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.csIlot.DataPropertyName = "csIlot";
            this.csIlot.HeaderText = "مجموعة الملكية";
            this.csIlot.Name = "csIlot";
            this.csIlot.ReadOnly = true;
            this.csIlot.Width = 123;
            // 
            // csLot
            // 
            this.csLot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.csLot.DataPropertyName = "csLot";
            this.csLot.HeaderText = "الرقم";
            this.csLot.Name = "csLot";
            this.csLot.ReadOnly = true;
            this.csLot.Width = 61;
            // 
            // csTown
            // 
            this.csTown.DataPropertyName = "csTown";
            this.csTown.HeaderText = "البلدية";
            this.csTown.Name = "csTown";
            this.csTown.ReadOnly = true;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStatistics.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnStatistics.Image = global::FouziaApp.Properties.Resources.analystic;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.ImageSize = 45;
            this.btnStatistics.Location = new System.Drawing.Point(18, 17);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(138, 45);
            this.btnStatistics.TabIndex = 20;
            this.btnStatistics.Text = "الإحصائيات";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatistics.UseSelectable = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // addPerson
            // 
            this.addPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPerson.Image = global::FouziaApp.Properties.Resources.plus1;
            this.addPerson.ImageSize = 25;
            this.addPerson.Location = new System.Drawing.Point(245, 25);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(36, 32);
            this.addPerson.Style = MetroFramework.MetroColorStyle.Green;
            this.addPerson.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.addPerson, "إضافة شخص");
            this.addPerson.UseSelectable = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // addCaseSubj
            // 
            this.addCaseSubj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addCaseSubj.Image = global::FouziaApp.Properties.Resources.plus1;
            this.addCaseSubj.ImageSize = 25;
            this.addCaseSubj.Location = new System.Drawing.Point(950, 53);
            this.addCaseSubj.Name = "addCaseSubj";
            this.addCaseSubj.Size = new System.Drawing.Size(28, 23);
            this.addCaseSubj.Style = MetroFramework.MetroColorStyle.Green;
            this.addCaseSubj.TabIndex = 19;
            this.metroToolTip1.SetToolTip(this.addCaseSubj, "إضافة موضوع قضية");
            this.addCaseSubj.UseSelectable = true;
            this.addCaseSubj.Click += new System.EventHandler(this.addCaseSubj_Click);
            // 
            // txtPerson
            // 
            this.txtPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPerson.CustomButton.Image = null;
            this.txtPerson.CustomButton.Location = new System.Drawing.Point(466, 2);
            this.txtPerson.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerson.CustomButton.Name = "";
            this.txtPerson.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPerson.CustomButton.TabIndex = 1;
            this.txtPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPerson.CustomButton.UseSelectable = true;
            this.txtPerson.CustomButton.Visible = false;
            this.txtPerson.DisplayIcon = true;
            this.txtPerson.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPerson.Icon = global::FouziaApp.Properties.Resources.person;
            this.txtPerson.IconRight = true;
            this.txtPerson.Lines = new string[0];
            this.txtPerson.Location = new System.Drawing.Point(244, 24);
            this.txtPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerson.MaxLength = 32767;
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.PasswordChar = '\0';
            this.txtPerson.PromptText = "اسم الشخص";
            this.txtPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPerson.SelectedText = "";
            this.txtPerson.SelectionLength = 0;
            this.txtPerson.SelectionStart = 0;
            this.txtPerson.ShortcutsEnabled = true;
            this.txtPerson.ShowClearButton = true;
            this.txtPerson.Size = new System.Drawing.Size(498, 34);
            this.txtPerson.TabIndex = 3;
            this.txtPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPerson.UseSelectable = true;
            this.txtPerson.WaterMark = "اسم الشخص";
            this.txtPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPerson.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // caseSubjectBindingSource
            // 
            this.caseSubjectBindingSource.DataSource = typeof(FouziaApp.caseSubject_tbl);
            // 
            // personstblBindingSource
            // 
            this.personstblBindingSource.DataSource = typeof(FouziaApp.persons_tbl);
            // 
            // partiesToTheConflicttblBindingSource
            // 
            this.partiesToTheConflicttblBindingSource.DataSource = typeof(FouziaApp.partiesToTheConflict_tbl);
            // 
            // ucDisputes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.addPerson);
            this.Controls.Add(this.addCaseSubj);
            this.Controls.Add(this.mtdgvPerson);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDisputes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(991, 450);
            this.Load += new System.EventHandler(this.ucDisputes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mtdgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personstblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesToTheConflicttblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource personstblBindingSource;
        private System.Windows.Forms.BindingSource partiesToTheConflicttblBindingSource;
        private System.Windows.Forms.BindingSource caseSubjectBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private MetroFramework.Controls.MetroGrid mtdgvPerson;
        private MetroFramework.Controls.MetroLink addCaseSubj;
        private MetroFramework.Controls.MetroLink addPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn الشخص;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseSubject_tbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn csIlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn csLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn csTown;
        private MetroFramework.Controls.MetroLink btnStatistics;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}
