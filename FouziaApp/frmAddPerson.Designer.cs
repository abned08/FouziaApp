namespace FouziaApp
{
    partial class frmAddPerson
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
            this.txtPersonName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbCaseSubj = new MetroFramework.Controls.MetroComboBox();
            this.cbPTC = new MetroFramework.Controls.MetroComboBox();
            this.dgvPerson = new MetroFramework.Controls.MetroGrid();
            this.personName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTCIDDataGridViewComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.csIDDataGridViewComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.btnDelete = new MetroFramework.Controls.MetroLink();
            this.btnAddToContext = new MetroFramework.Controls.MetroLink();
            this.addPerson = new MetroFramework.Controls.MetroLink();
            this.txtSearchPerson = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.personstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partiesToTheConflicttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caseSubjecttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partiesToTheConflicttblDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseSubjecttblDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personstblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesToTheConflicttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseSubjecttblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonName
            // 
            this.txtPersonName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPersonName.CustomButton.Image = null;
            this.txtPersonName.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtPersonName.CustomButton.Name = "";
            this.txtPersonName.CustomButton.Size = new System.Drawing.Size(117, 117);
            this.txtPersonName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPersonName.CustomButton.TabIndex = 1;
            this.txtPersonName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPersonName.CustomButton.UseSelectable = true;
            this.txtPersonName.CustomButton.Visible = false;
            this.txtPersonName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personstblBindingSource, "personName", true));
            this.txtPersonName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPersonName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPersonName.Lines = new string[0];
            this.txtPersonName.Location = new System.Drawing.Point(21, 58);
            this.txtPersonName.MaxLength = 32767;
            this.txtPersonName.Multiline = true;
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.PasswordChar = '\0';
            this.txtPersonName.PromptText = "اسم الشخص";
            this.txtPersonName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPersonName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPersonName.SelectedText = "";
            this.txtPersonName.SelectionLength = 0;
            this.txtPersonName.SelectionStart = 0;
            this.txtPersonName.ShortcutsEnabled = true;
            this.txtPersonName.Size = new System.Drawing.Size(248, 119);
            this.txtPersonName.TabIndex = 1;
            this.txtPersonName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPersonName.UseSelectable = true;
            this.txtPersonName.WaterMark = "اسم الشخص";
            this.txtPersonName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPersonName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(511, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 25);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = ": اسم الشخص";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(511, 236);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = ": مدخلية الخصام";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(510, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(138, 25);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = ": موضوع القضية";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbCaseSubj
            // 
            this.cbCaseSubj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCaseSubj.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personstblBindingSource, "csID", true));
            this.cbCaseSubj.FormattingEnabled = true;
            this.cbCaseSubj.ItemHeight = 23;
            this.cbCaseSubj.Location = new System.Drawing.Point(21, 17);
            this.cbCaseSubj.Name = "cbCaseSubj";
            this.cbCaseSubj.Size = new System.Drawing.Size(248, 29);
            this.cbCaseSubj.TabIndex = 0;
            this.cbCaseSubj.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbCaseSubj.UseSelectable = true;
            // 
            // cbPTC
            // 
            this.cbPTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPTC.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personstblBindingSource, "PTCID", true));
            this.cbPTC.FormattingEnabled = true;
            this.cbPTC.ItemHeight = 23;
            this.cbPTC.Location = new System.Drawing.Point(21, 183);
            this.cbPTC.Name = "cbPTC";
            this.cbPTC.Size = new System.Drawing.Size(248, 29);
            this.cbPTC.TabIndex = 2;
            this.cbPTC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbPTC.UseSelectable = true;
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.AllowUserToResizeRows = false;
            this.dgvPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPerson.AutoGenerateColumns = false;
            this.dgvPerson.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPerson.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPerson.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personName,
            this.PTCIDDataGridViewComboBox,
            this.csIDDataGridViewComboBox,
            this.personIDDataGridViewTextBoxColumn,
            this.personNameDataGridViewTextBoxColumn,
            this.pTCIDDataGridViewTextBoxColumn,
            this.csIDDataGridViewTextBoxColumn,
            this.partiesToTheConflicttblDataGridViewTextBoxColumn,
            this.caseSubjecttblDataGridViewTextBoxColumn});
            this.dgvPerson.DataSource = this.personstblBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerson.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPerson.EnableHeadersVisualStyles = false;
            this.dgvPerson.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPerson.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvPerson.Location = new System.Drawing.Point(12, 308);
            this.dgvPerson.MultiSelect = false;
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPerson.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerson.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPerson.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(634, 228);
            this.dgvPerson.TabIndex = 26;
            this.dgvPerson.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
            this.dgvPerson.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPerson_DataError);
            // 
            // personName
            // 
            this.personName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personName.DataPropertyName = "personName";
            this.personName.HeaderText = "الشخص";
            this.personName.Name = "personName";
            this.personName.ReadOnly = true;
            // 
            // PTCIDDataGridViewComboBox
            // 
            this.PTCIDDataGridViewComboBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PTCIDDataGridViewComboBox.DataPropertyName = "PTCID";
            this.PTCIDDataGridViewComboBox.DataSource = this.partiesToTheConflicttblBindingSource;
            this.PTCIDDataGridViewComboBox.DisplayMember = "PTCName";
            this.PTCIDDataGridViewComboBox.HeaderText = "مدخلية الخصام";
            this.PTCIDDataGridViewComboBox.Name = "PTCIDDataGridViewComboBox";
            this.PTCIDDataGridViewComboBox.ReadOnly = true;
            this.PTCIDDataGridViewComboBox.ValueMember = "PTCID";
            this.PTCIDDataGridViewComboBox.Width = 93;
            // 
            // csIDDataGridViewComboBox
            // 
            this.csIDDataGridViewComboBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.csIDDataGridViewComboBox.DataPropertyName = "csID";
            this.csIDDataGridViewComboBox.DataSource = this.caseSubjecttblBindingSource;
            this.csIDDataGridViewComboBox.DisplayMember = "csAdress";
            this.csIDDataGridViewComboBox.HeaderText = "موضوع القضية";
            this.csIDDataGridViewComboBox.Name = "csIDDataGridViewComboBox";
            this.csIDDataGridViewComboBox.ReadOnly = true;
            this.csIDDataGridViewComboBox.ValueMember = "csID";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnSave.Image = global::FouziaApp.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageSize = 45;
            this.btnSave.Location = new System.Drawing.Point(257, 548);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = global::FouziaApp.Properties.Resources.save;
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "حـــــــفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Image = global::FouziaApp.Properties.Resources.delete;
            this.btnDelete.ImageSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(201, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoFocusImage = global::FouziaApp.Properties.Resources.delete;
            this.btnDelete.Size = new System.Drawing.Size(36, 32);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDelete.TabIndex = 30;
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
            this.btnAddToContext.Location = new System.Drawing.Point(201, 233);
            this.btnAddToContext.Name = "btnAddToContext";
            this.btnAddToContext.NoFocusImage = global::FouziaApp.Properties.Resources.check;
            this.btnAddToContext.Size = new System.Drawing.Size(36, 32);
            this.btnAddToContext.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAddToContext.TabIndex = 1;
            this.btnAddToContext.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddToContext.UseSelectable = true;
            this.btnAddToContext.Click += new System.EventHandler(this.btnAddToContext_Click);
            // 
            // addPerson
            // 
            this.addPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addPerson.Image = global::FouziaApp.Properties.Resources.plus1;
            this.addPerson.ImageSize = 25;
            this.addPerson.Location = new System.Drawing.Point(565, 139);
            this.addPerson.Name = "addPerson";
            this.addPerson.NoFocusImage = global::FouziaApp.Properties.Resources.plus1;
            this.addPerson.Size = new System.Drawing.Size(36, 32);
            this.addPerson.Style = MetroFramework.MetroColorStyle.Green;
            this.addPerson.TabIndex = 28;
            this.addPerson.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addPerson.UseSelectable = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearchPerson.CustomButton.Image = null;
            this.txtSearchPerson.CustomButton.Location = new System.Drawing.Point(612, 1);
            this.txtSearchPerson.CustomButton.Name = "";
            this.txtSearchPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchPerson.CustomButton.TabIndex = 1;
            this.txtSearchPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchPerson.CustomButton.UseSelectable = true;
            this.txtSearchPerson.CustomButton.Visible = false;
            this.txtSearchPerson.DisplayIcon = true;
            this.txtSearchPerson.Icon = global::FouziaApp.Properties.Resources.person;
            this.txtSearchPerson.IconRight = true;
            this.txtSearchPerson.Lines = new string[0];
            this.txtSearchPerson.Location = new System.Drawing.Point(12, 279);
            this.txtSearchPerson.MaxLength = 32767;
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.PasswordChar = '\0';
            this.txtSearchPerson.PromptText = "ابحث عن شخص";
            this.txtSearchPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchPerson.SelectedText = "";
            this.txtSearchPerson.SelectionLength = 0;
            this.txtSearchPerson.SelectionStart = 0;
            this.txtSearchPerson.ShortcutsEnabled = true;
            this.txtSearchPerson.ShowClearButton = true;
            this.txtSearchPerson.Size = new System.Drawing.Size(634, 23);
            this.txtSearchPerson.Style = MetroFramework.MetroColorStyle.Black;
            this.txtSearchPerson.TabIndex = 2;
            this.txtSearchPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchPerson.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchPerson.UseSelectable = true;
            this.txtSearchPerson.WaterMark = "ابحث عن شخص";
            this.txtSearchPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchPerson.TextChanged += new System.EventHandler(this.txtSearchPerson_TextChanged);
            // 
            // metroPanel
            // 
            this.metroPanel.Controls.Add(this.cbPTC);
            this.metroPanel.Controls.Add(this.cbCaseSubj);
            this.metroPanel.Controls.Add(this.txtPersonName);
            this.metroPanel.Enabled = false;
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(240, 51);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(275, 226);
            this.metroPanel.TabIndex = 0;
            this.metroPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // personstblBindingSource
            // 
            this.personstblBindingSource.DataSource = typeof(FouziaApp.persons_tbl);
            // 
            // partiesToTheConflicttblBindingSource
            // 
            this.partiesToTheConflicttblBindingSource.DataSource = typeof(FouziaApp.partiesToTheConflict_tbl);
            // 
            // caseSubjecttblBindingSource
            // 
            this.caseSubjecttblBindingSource.DataSource = typeof(FouziaApp.caseSubject_tbl);
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "personID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "personID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // personNameDataGridViewTextBoxColumn
            // 
            this.personNameDataGridViewTextBoxColumn.DataPropertyName = "personName";
            this.personNameDataGridViewTextBoxColumn.HeaderText = "personName";
            this.personNameDataGridViewTextBoxColumn.Name = "personNameDataGridViewTextBoxColumn";
            this.personNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.personNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // pTCIDDataGridViewTextBoxColumn
            // 
            this.pTCIDDataGridViewTextBoxColumn.DataPropertyName = "PTCID";
            this.pTCIDDataGridViewTextBoxColumn.HeaderText = "PTCID";
            this.pTCIDDataGridViewTextBoxColumn.Name = "pTCIDDataGridViewTextBoxColumn";
            this.pTCIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pTCIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // csIDDataGridViewTextBoxColumn
            // 
            this.csIDDataGridViewTextBoxColumn.DataPropertyName = "csID";
            this.csIDDataGridViewTextBoxColumn.HeaderText = "csID";
            this.csIDDataGridViewTextBoxColumn.Name = "csIDDataGridViewTextBoxColumn";
            this.csIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.csIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // partiesToTheConflicttblDataGridViewTextBoxColumn
            // 
            this.partiesToTheConflicttblDataGridViewTextBoxColumn.DataPropertyName = "partiesToTheConflict_tbl";
            this.partiesToTheConflicttblDataGridViewTextBoxColumn.HeaderText = "partiesToTheConflict_tbl";
            this.partiesToTheConflicttblDataGridViewTextBoxColumn.Name = "partiesToTheConflicttblDataGridViewTextBoxColumn";
            this.partiesToTheConflicttblDataGridViewTextBoxColumn.ReadOnly = true;
            this.partiesToTheConflicttblDataGridViewTextBoxColumn.Visible = false;
            // 
            // caseSubjecttblDataGridViewTextBoxColumn
            // 
            this.caseSubjecttblDataGridViewTextBoxColumn.DataPropertyName = "caseSubject_tbl";
            this.caseSubjecttblDataGridViewTextBoxColumn.HeaderText = "caseSubject_tbl";
            this.caseSubjecttblDataGridViewTextBoxColumn.Name = "caseSubjecttblDataGridViewTextBoxColumn";
            this.caseSubjecttblDataGridViewTextBoxColumn.ReadOnly = true;
            this.caseSubjecttblDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmAddPerson
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 616);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddToContext);
            this.Controls.Add(this.addPerson);
            this.Controls.Add(this.txtSearchPerson);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.MaximizeBox = false;
            this.Name = "frmAddPerson";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "إضافة (تعديل) شخص";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmAddPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.metroPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personstblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesToTheConflicttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseSubjecttblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtPersonName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbCaseSubj;
        private MetroFramework.Controls.MetroComboBox cbPTC;
        private MetroFramework.Controls.MetroLink btnSave;
        private System.Windows.Forms.BindingSource personstblBindingSource;
        private MetroFramework.Controls.MetroGrid dgvPerson;
        private System.Windows.Forms.BindingSource partiesToTheConflicttblBindingSource;
        private System.Windows.Forms.BindingSource caseSubjecttblBindingSource;
        private MetroFramework.Controls.MetroTextBox txtSearchPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn personName;
        private System.Windows.Forms.DataGridViewComboBoxColumn PTCIDDataGridViewComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn csIDDataGridViewComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partiesToTheConflicttblDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseSubjecttblDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLink addPerson;
        private MetroFramework.Controls.MetroLink btnAddToContext;
        private MetroFramework.Controls.MetroLink btnDelete;
        private MetroFramework.Controls.MetroPanel metroPanel;
    }
}