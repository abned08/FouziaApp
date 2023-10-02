namespace FouziaApp
{
    partial class frmAddCaseSubj
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
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.txtAdress = new MetroFramework.Controls.MetroTextBox();
            this.caseSubjecttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtSec = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtIlot = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtLot = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtTown = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbRecordNum = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbCatSub = new MetroFramework.Controls.MetroComboBox();
            this.recordtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catSubPlus = new MetroFramework.Controls.MetroLink();
            this.recordPlus = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.caseSubjecttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordtblBindingSource)).BeginInit();
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
            this.btnSave.Location = new System.Drawing.Point(153, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = global::FouziaApp.Properties.Resources.save;
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "حـــــــفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAdress.CustomButton.Image = null;
            this.txtAdress.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txtAdress.CustomButton.Name = "";
            this.txtAdress.CustomButton.Size = new System.Drawing.Size(187, 187);
            this.txtAdress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdress.CustomButton.TabIndex = 1;
            this.txtAdress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdress.CustomButton.UseSelectable = true;
            this.txtAdress.CustomButton.Visible = false;
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseSubjecttblBindingSource, "csAdress", true));
            this.txtAdress.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAdress.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtAdress.Lines = new string[0];
            this.txtAdress.Location = new System.Drawing.Point(23, 347);
            this.txtAdress.MaxLength = 32767;
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.PasswordChar = '\0';
            this.txtAdress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdress.SelectedText = "";
            this.txtAdress.SelectionLength = 0;
            this.txtAdress.SelectionStart = 0;
            this.txtAdress.ShortcutsEnabled = true;
            this.txtAdress.Size = new System.Drawing.Size(341, 189);
            this.txtAdress.TabIndex = 5;
            this.txtAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAdress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAdress.UseSelectable = true;
            this.txtAdress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // caseSubjecttblBindingSource
            // 
            this.caseSubjecttblBindingSource.DataSource = typeof(FouziaApp.caseSubject_tbl);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(370, 347);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(91, 25);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = ": الموضوع";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtSec
            // 
            this.txtSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSec.CustomButton.Image = null;
            this.txtSec.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.txtSec.CustomButton.Name = "";
            this.txtSec.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtSec.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSec.CustomButton.TabIndex = 1;
            this.txtSec.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSec.CustomButton.UseSelectable = true;
            this.txtSec.CustomButton.Visible = false;
            this.txtSec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseSubjecttblBindingSource, "csSec", true));
            this.txtSec.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSec.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtSec.Lines = new string[0];
            this.txtSec.Location = new System.Drawing.Point(223, 120);
            this.txtSec.MaxLength = 32767;
            this.txtSec.Multiline = true;
            this.txtSec.Name = "txtSec";
            this.txtSec.PasswordChar = '\0';
            this.txtSec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSec.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSec.SelectedText = "";
            this.txtSec.SelectionLength = 0;
            this.txtSec.SelectionStart = 0;
            this.txtSec.ShortcutsEnabled = true;
            this.txtSec.Size = new System.Drawing.Size(93, 33);
            this.txtSec.TabIndex = 1;
            this.txtSec.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSec.UseSelectable = true;
            this.txtSec.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSec.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(333, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 25);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = ": القسم";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtIlot
            // 
            this.txtIlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtIlot.CustomButton.Image = null;
            this.txtIlot.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.txtIlot.CustomButton.Name = "";
            this.txtIlot.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtIlot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIlot.CustomButton.TabIndex = 1;
            this.txtIlot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIlot.CustomButton.UseSelectable = true;
            this.txtIlot.CustomButton.Visible = false;
            this.txtIlot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseSubjecttblBindingSource, "csIlot", true));
            this.txtIlot.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtIlot.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtIlot.Lines = new string[0];
            this.txtIlot.Location = new System.Drawing.Point(223, 162);
            this.txtIlot.MaxLength = 32767;
            this.txtIlot.Multiline = true;
            this.txtIlot.Name = "txtIlot";
            this.txtIlot.PasswordChar = '\0';
            this.txtIlot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIlot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIlot.SelectedText = "";
            this.txtIlot.SelectionLength = 0;
            this.txtIlot.SelectionStart = 0;
            this.txtIlot.ShortcutsEnabled = true;
            this.txtIlot.Size = new System.Drawing.Size(93, 33);
            this.txtIlot.TabIndex = 2;
            this.txtIlot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtIlot.UseSelectable = true;
            this.txtIlot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIlot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(333, 166);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 25);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = ": مجموعة الملكية";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtLot
            // 
            this.txtLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtLot.CustomButton.Image = null;
            this.txtLot.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.txtLot.CustomButton.Name = "";
            this.txtLot.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtLot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLot.CustomButton.TabIndex = 1;
            this.txtLot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLot.CustomButton.UseSelectable = true;
            this.txtLot.CustomButton.Visible = false;
            this.txtLot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseSubjecttblBindingSource, "csLot", true));
            this.txtLot.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLot.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtLot.Lines = new string[0];
            this.txtLot.Location = new System.Drawing.Point(223, 201);
            this.txtLot.MaxLength = 32767;
            this.txtLot.Multiline = true;
            this.txtLot.Name = "txtLot";
            this.txtLot.PasswordChar = '\0';
            this.txtLot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLot.SelectedText = "";
            this.txtLot.SelectionLength = 0;
            this.txtLot.SelectionStart = 0;
            this.txtLot.ShortcutsEnabled = true;
            this.txtLot.Size = new System.Drawing.Size(93, 33);
            this.txtLot.TabIndex = 3;
            this.txtLot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtLot.UseSelectable = true;
            this.txtLot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(333, 205);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 25);
            this.metroLabel6.TabIndex = 38;
            this.metroLabel6.Text = ": الرقم";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtTown
            // 
            this.txtTown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTown.CustomButton.Image = null;
            this.txtTown.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.txtTown.CustomButton.Name = "";
            this.txtTown.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtTown.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTown.CustomButton.TabIndex = 1;
            this.txtTown.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTown.CustomButton.UseSelectable = true;
            this.txtTown.CustomButton.Visible = false;
            this.txtTown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseSubjecttblBindingSource, "csTown", true));
            this.txtTown.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTown.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTown.Lines = new string[0];
            this.txtTown.Location = new System.Drawing.Point(223, 240);
            this.txtTown.MaxLength = 32767;
            this.txtTown.Multiline = true;
            this.txtTown.Name = "txtTown";
            this.txtTown.PasswordChar = '\0';
            this.txtTown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTown.SelectedText = "";
            this.txtTown.SelectionLength = 0;
            this.txtTown.SelectionStart = 0;
            this.txtTown.ShortcutsEnabled = true;
            this.txtTown.Size = new System.Drawing.Size(93, 33);
            this.txtTown.TabIndex = 4;
            this.txtTown.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTown.UseSelectable = true;
            this.txtTown.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTown.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(333, 244);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(69, 25);
            this.metroLabel7.TabIndex = 40;
            this.metroLabel7.Text = ": البلدية";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(333, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 25);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = ": رقم السجل";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbRecordNum
            // 
            this.cbRecordNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRecordNum.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.caseSubjecttblBindingSource, "recordID", true));
            this.cbRecordNum.FormattingEnabled = true;
            this.cbRecordNum.ItemHeight = 23;
            this.cbRecordNum.Location = new System.Drawing.Point(223, 81);
            this.cbRecordNum.Name = "cbRecordNum";
            this.cbRecordNum.Size = new System.Drawing.Size(93, 29);
            this.cbRecordNum.TabIndex = 0;
            this.cbRecordNum.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbRecordNum.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(333, 275);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 50);
            this.metroLabel4.TabIndex = 44;
            this.metroLabel4.Text = ": صنف \r\nموضوع القضية";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.WrapToLine = true;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // cbCatSub
            // 
            this.cbCatSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCatSub.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.caseSubjecttblBindingSource, "catSubID", true));
            this.cbCatSub.FormattingEnabled = true;
            this.cbCatSub.ItemHeight = 23;
            this.cbCatSub.Location = new System.Drawing.Point(45, 287);
            this.cbCatSub.Name = "cbCatSub";
            this.cbCatSub.Size = new System.Drawing.Size(271, 29);
            this.cbCatSub.TabIndex = 45;
            this.cbCatSub.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbCatSub.UseSelectable = true;
            // 
            // recordtblBindingSource
            // 
            this.recordtblBindingSource.DataSource = typeof(FouziaApp.record_tbl);
            // 
            // catSubPlus
            // 
            this.catSubPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.catSubPlus.Image = global::FouziaApp.Properties.Resources.plus1;
            this.catSubPlus.ImageSize = 25;
            this.catSubPlus.Location = new System.Drawing.Point(11, 287);
            this.catSubPlus.Name = "catSubPlus";
            this.catSubPlus.NoFocusImage = global::FouziaApp.Properties.Resources.plus1;
            this.catSubPlus.Size = new System.Drawing.Size(28, 29);
            this.catSubPlus.Style = MetroFramework.MetroColorStyle.Green;
            this.catSubPlus.TabIndex = 46;
            this.catSubPlus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.catSubPlus.UseSelectable = true;
            this.catSubPlus.Click += new System.EventHandler(this.catSubPlus_Click);
            // 
            // recordPlus
            // 
            this.recordPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recordPlus.Image = global::FouziaApp.Properties.Resources.plus1;
            this.recordPlus.ImageSize = 25;
            this.recordPlus.Location = new System.Drawing.Point(189, 81);
            this.recordPlus.Name = "recordPlus";
            this.recordPlus.NoFocusImage = global::FouziaApp.Properties.Resources.plus1;
            this.recordPlus.Size = new System.Drawing.Size(28, 29);
            this.recordPlus.Style = MetroFramework.MetroColorStyle.Green;
            this.recordPlus.TabIndex = 47;
            this.recordPlus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.recordPlus.UseSelectable = true;
            this.recordPlus.Click += new System.EventHandler(this.recordPlus_Click);
            // 
            // frmAddCaseSubj
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 599);
            this.Controls.Add(this.recordPlus);
            this.Controls.Add(this.catSubPlus);
            this.Controls.Add(this.cbCatSub);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbRecordNum);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtLot);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtIlot);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.metroLabel2);
            this.MaximizeBox = false;
            this.Name = "frmAddCaseSubj";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "إضافة (تعديل) موضوع قضية";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmAddCaseSubj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caseSubjecttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordtblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroTextBox txtAdress;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtSec;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtIlot;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtLot;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtTown;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbRecordNum;
        private System.Windows.Forms.BindingSource recordtblBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbCatSub;
        private System.Windows.Forms.BindingSource caseSubjecttblBindingSource;
        private MetroFramework.Controls.MetroLink catSubPlus;
        private MetroFramework.Controls.MetroLink recordPlus;
    }
}