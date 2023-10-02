namespace FouziaApp
{
    partial class AddCase
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
            this.txtCaseNum = new MetroFramework.Controls.MetroTextBox();
            this.casetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDateOfTheOpenPetition = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateOfTheReply = new MetroFramework.Controls.MetroDateTime();
            this.dtpDateOfTheJudgment = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJudgment = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkFinished = new MetroFramework.Controls.MetroCheckBox();
            this.dtpDateOfTheExpertCall = new MetroFramework.Controls.MetroDateTime();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateOfReplyToTheExpert = new MetroFramework.Controls.MetroDateTime();
            this.label8 = new System.Windows.Forms.Label();
            this.cbService = new MetroFramework.Controls.MetroComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbReceiptOfCase = new MetroFramework.Controls.MetroComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCaseSubject = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.btnCaseFileUpload = new MetroFramework.Controls.MetroLink();
            this.txtPDFPath = new MetroFramework.Controls.MetroTextBox();
            this.txtRceiptOfCase = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbJudgmentOnTheCase = new MetroFramework.Controls.MetroComboBox();
            this.rcPlus = new MetroFramework.Controls.MetroLink();
            this.JOCPlus = new MetroFramework.Controls.MetroLink();
            this.receiptOfCasetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caseSubjecttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicePlus = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.casetblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptOfCasetblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicetblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseSubjecttblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCaseNum
            // 
            this.txtCaseNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCaseNum.CustomButton.Image = null;
            this.txtCaseNum.CustomButton.Location = new System.Drawing.Point(233, 2);
            this.txtCaseNum.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaseNum.CustomButton.Name = "";
            this.txtCaseNum.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtCaseNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCaseNum.CustomButton.TabIndex = 1;
            this.txtCaseNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCaseNum.CustomButton.UseSelectable = true;
            this.txtCaseNum.CustomButton.Visible = false;
            this.txtCaseNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casetblBindingSource, "caseNum", true));
            this.txtCaseNum.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCaseNum.Lines = new string[0];
            this.txtCaseNum.Location = new System.Drawing.Point(165, 171);
            this.txtCaseNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaseNum.MaxLength = 32767;
            this.txtCaseNum.Name = "txtCaseNum";
            this.txtCaseNum.PasswordChar = '\0';
            this.txtCaseNum.PromptText = "رقم القضية";
            this.txtCaseNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCaseNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCaseNum.SelectedText = "";
            this.txtCaseNum.SelectionLength = 0;
            this.txtCaseNum.SelectionStart = 0;
            this.txtCaseNum.ShortcutsEnabled = true;
            this.txtCaseNum.ShowClearButton = true;
            this.txtCaseNum.Size = new System.Drawing.Size(265, 34);
            this.txtCaseNum.TabIndex = 3;
            this.txtCaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCaseNum.UseSelectable = true;
            this.txtCaseNum.WaterMark = "رقم القضية";
            this.txtCaseNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCaseNum.WaterMarkFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // casetblBindingSource
            // 
            this.casetblBindingSource.DataSource = typeof(FouziaApp.case_tbl);
            // 
            // dtpDateOfTheOpenPetition
            // 
            this.dtpDateOfTheOpenPetition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfTheOpenPetition.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.casetblBindingSource, "dateOfTheOpenPetition", true));
            this.dtpDateOfTheOpenPetition.DisplayFocus = true;
            this.dtpDateOfTheOpenPetition.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateOfTheOpenPetition.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfTheOpenPetition.Location = new System.Drawing.Point(163, 211);
            this.dtpDateOfTheOpenPetition.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateOfTheOpenPetition.Name = "dtpDateOfTheOpenPetition";
            this.dtpDateOfTheOpenPetition.Size = new System.Drawing.Size(266, 29);
            this.dtpDateOfTheOpenPetition.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم القضية:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "تاريخ العريضة الافتتاحية:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "تاريخ الرد:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDateOfTheReply
            // 
            this.dtpDateOfTheReply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfTheReply.Checked = false;
            this.dtpDateOfTheReply.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.casetblBindingSource, "dateOfTheReply", true));
            this.dtpDateOfTheReply.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateOfTheReply.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfTheReply.Location = new System.Drawing.Point(165, 246);
            this.dtpDateOfTheReply.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateOfTheReply.Name = "dtpDateOfTheReply";
            this.dtpDateOfTheReply.Size = new System.Drawing.Size(266, 29);
            this.dtpDateOfTheReply.TabIndex = 5;
            // 
            // dtpDateOfTheJudgment
            // 
            this.dtpDateOfTheJudgment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfTheJudgment.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.casetblBindingSource, "dateOfTheJudgment", true));
            this.dtpDateOfTheJudgment.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateOfTheJudgment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfTheJudgment.Location = new System.Drawing.Point(165, 283);
            this.dtpDateOfTheJudgment.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateOfTheJudgment.Name = "dtpDateOfTheJudgment";
            this.dtpDateOfTheJudgment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDateOfTheJudgment.RightToLeftLayout = true;
            this.dtpDateOfTheJudgment.Size = new System.Drawing.Size(266, 29);
            this.dtpDateOfTheJudgment.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "تاريخ الحكم:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "موضوع الحكم:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtJudgment
            // 
            this.txtJudgment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtJudgment.CustomButton.Image = null;
            this.txtJudgment.CustomButton.Location = new System.Drawing.Point(262, 1);
            this.txtJudgment.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtJudgment.CustomButton.Name = "";
            this.txtJudgment.CustomButton.Size = new System.Drawing.Size(121, 121);
            this.txtJudgment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJudgment.CustomButton.TabIndex = 1;
            this.txtJudgment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJudgment.CustomButton.UseSelectable = true;
            this.txtJudgment.CustomButton.Visible = false;
            this.txtJudgment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casetblBindingSource, "judgment", true));
            this.txtJudgment.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtJudgment.Lines = new string[0];
            this.txtJudgment.Location = new System.Drawing.Point(47, 320);
            this.txtJudgment.Margin = new System.Windows.Forms.Padding(4);
            this.txtJudgment.MaxLength = 32767;
            this.txtJudgment.Multiline = true;
            this.txtJudgment.Name = "txtJudgment";
            this.txtJudgment.PasswordChar = '\0';
            this.txtJudgment.PromptText = "موضوع الحكم";
            this.txtJudgment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtJudgment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJudgment.SelectedText = "";
            this.txtJudgment.SelectionLength = 0;
            this.txtJudgment.SelectionStart = 0;
            this.txtJudgment.ShortcutsEnabled = false;
            this.txtJudgment.ShowClearButton = true;
            this.txtJudgment.Size = new System.Drawing.Size(384, 123);
            this.txtJudgment.TabIndex = 7;
            this.txtJudgment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJudgment.UseSelectable = true;
            this.txtJudgment.WaterMark = "موضوع الحكم";
            this.txtJudgment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJudgment.WaterMarkFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "منتهية ؟";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkFinished
            // 
            this.chkFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFinished.AutoSize = true;
            this.chkFinished.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.casetblBindingSource, "finished", true));
            this.chkFinished.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkFinished.Location = new System.Drawing.Point(396, 457);
            this.chkFinished.Name = "chkFinished";
            this.chkFinished.Size = new System.Drawing.Size(35, 25);
            this.chkFinished.TabIndex = 8;
            this.chkFinished.Text = "-";
            this.chkFinished.UseSelectable = true;
            this.chkFinished.CheckedChanged += new System.EventHandler(this.chkFinished_CheckedChanged);
            // 
            // dtpDateOfTheExpertCall
            // 
            this.dtpDateOfTheExpertCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfTheExpertCall.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.casetblBindingSource, "dateOfTheExpertsCall", true));
            this.dtpDateOfTheExpertCall.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfTheExpertCall.Location = new System.Drawing.Point(298, 486);
            this.dtpDateOfTheExpertCall.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateOfTheExpertCall.Name = "dtpDateOfTheExpertCall";
            this.dtpDateOfTheExpertCall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDateOfTheExpertCall.RightToLeftLayout = true;
            this.dtpDateOfTheExpertCall.Size = new System.Drawing.Size(132, 29);
            this.dtpDateOfTheExpertCall.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "تاريخ استدعاء الخبير:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDateOfReplyToTheExpert
            // 
            this.dtpDateOfReplyToTheExpert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfReplyToTheExpert.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.casetblBindingSource, "dateOfReplyToTheExpert", true));
            this.dtpDateOfReplyToTheExpert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfReplyToTheExpert.Location = new System.Drawing.Point(11, 486);
            this.dtpDateOfReplyToTheExpert.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateOfReplyToTheExpert.Name = "dtpDateOfReplyToTheExpert";
            this.dtpDateOfReplyToTheExpert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDateOfReplyToTheExpert.RightToLeftLayout = true;
            this.dtpDateOfReplyToTheExpert.Size = new System.Drawing.Size(132, 29);
            this.dtpDateOfReplyToTheExpert.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "تاريخ الرد على الخبير:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbService
            // 
            this.cbService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbService.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.casetblBindingSource, "serviceID", true));
            this.cbService.FormattingEnabled = true;
            this.cbService.ItemHeight = 23;
            this.cbService.Location = new System.Drawing.Point(35, 97);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(396, 29);
            this.cbService.TabIndex = 1;
            this.cbService.UseSelectable = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(429, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "المصلحة:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbReceiptOfCase
            // 
            this.cbReceiptOfCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbReceiptOfCase.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.casetblBindingSource, "rcID", true));
            this.cbReceiptOfCase.FormattingEnabled = true;
            this.cbReceiptOfCase.ItemHeight = 23;
            this.cbReceiptOfCase.Location = new System.Drawing.Point(165, 132);
            this.cbReceiptOfCase.Name = "cbReceiptOfCase";
            this.cbReceiptOfCase.Size = new System.Drawing.Size(266, 29);
            this.cbReceiptOfCase.Style = MetroFramework.MetroColorStyle.Red;
            this.cbReceiptOfCase.TabIndex = 2;
            this.cbReceiptOfCase.UseSelectable = true;
            this.cbReceiptOfCase.SelectedIndexChanged += new System.EventHandler(this.cbReceiptOfCase_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(429, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "تاريخ استلام القضية:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(428, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "موضوع القضية:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCaseSubject
            // 
            this.cbCaseSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCaseSubject.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.casetblBindingSource, "csID", true));
            this.cbCaseSubject.FormattingEnabled = true;
            this.cbCaseSubject.ItemHeight = 23;
            this.cbCaseSubject.Location = new System.Drawing.Point(35, 62);
            this.cbCaseSubject.Name = "cbCaseSubject";
            this.cbCaseSubject.Size = new System.Drawing.Size(395, 29);
            this.cbCaseSubject.TabIndex = 0;
            this.cbCaseSubject.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnSave.Image = global::FouziaApp.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageSize = 45;
            this.btnSave.Location = new System.Drawing.Point(232, 627);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "حـــــــفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCaseFileUpload
            // 
            this.btnCaseFileUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaseFileUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCaseFileUpload.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnCaseFileUpload.Image = global::FouziaApp.Properties.Resources.pdf;
            this.btnCaseFileUpload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCaseFileUpload.ImageSize = 45;
            this.btnCaseFileUpload.Location = new System.Drawing.Point(21, 569);
            this.btnCaseFileUpload.Name = "btnCaseFileUpload";
            this.btnCaseFileUpload.Size = new System.Drawing.Size(113, 74);
            this.btnCaseFileUpload.TabIndex = 22;
            this.btnCaseFileUpload.Text = "ملف القضية";
            this.btnCaseFileUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCaseFileUpload.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCaseFileUpload.UseSelectable = true;
            this.btnCaseFileUpload.Click += new System.EventHandler(this.btnCaseFileUpload_Click);
            // 
            // txtPDFPath
            // 
            this.txtPDFPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPDFPath.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPDFPath.CustomButton.Image = null;
            this.txtPDFPath.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.txtPDFPath.CustomButton.Name = "";
            this.txtPDFPath.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPDFPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPDFPath.CustomButton.TabIndex = 1;
            this.txtPDFPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPDFPath.CustomButton.UseSelectable = true;
            this.txtPDFPath.CustomButton.Visible = false;
            this.txtPDFPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casetblBindingSource, "filePath", true));
            this.txtPDFPath.ForeColor = System.Drawing.Color.White;
            this.txtPDFPath.Lines = new string[0];
            this.txtPDFPath.Location = new System.Drawing.Point(14, 642);
            this.txtPDFPath.MaxLength = 32767;
            this.txtPDFPath.Name = "txtPDFPath";
            this.txtPDFPath.PasswordChar = '\0';
            this.txtPDFPath.ReadOnly = true;
            this.txtPDFPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPDFPath.SelectedText = "";
            this.txtPDFPath.SelectionLength = 0;
            this.txtPDFPath.SelectionStart = 0;
            this.txtPDFPath.ShortcutsEnabled = true;
            this.txtPDFPath.Size = new System.Drawing.Size(122, 30);
            this.txtPDFPath.TabIndex = 23;
            this.txtPDFPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPDFPath.UseSelectable = true;
            this.txtPDFPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPDFPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRceiptOfCase
            // 
            this.txtRceiptOfCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtRceiptOfCase.CustomButton.Image = null;
            this.txtRceiptOfCase.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtRceiptOfCase.CustomButton.Name = "";
            this.txtRceiptOfCase.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txtRceiptOfCase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRceiptOfCase.CustomButton.TabIndex = 1;
            this.txtRceiptOfCase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRceiptOfCase.CustomButton.UseSelectable = true;
            this.txtRceiptOfCase.CustomButton.Visible = false;
            this.txtRceiptOfCase.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRceiptOfCase.ForeColor = System.Drawing.Color.Red;
            this.txtRceiptOfCase.Lines = new string[0];
            this.txtRceiptOfCase.Location = new System.Drawing.Point(14, 132);
            this.txtRceiptOfCase.MaxLength = 32767;
            this.txtRceiptOfCase.Multiline = true;
            this.txtRceiptOfCase.Name = "txtRceiptOfCase";
            this.txtRceiptOfCase.PasswordChar = '\0';
            this.txtRceiptOfCase.ReadOnly = true;
            this.txtRceiptOfCase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRceiptOfCase.SelectedText = "";
            this.txtRceiptOfCase.SelectionLength = 0;
            this.txtRceiptOfCase.SelectionStart = 0;
            this.txtRceiptOfCase.ShortcutsEnabled = true;
            this.txtRceiptOfCase.Size = new System.Drawing.Size(145, 57);
            this.txtRceiptOfCase.Style = MetroFramework.MetroColorStyle.Red;
            this.txtRceiptOfCase.TabIndex = 24;
            this.txtRceiptOfCase.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRceiptOfCase.UseSelectable = true;
            this.txtRceiptOfCase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRceiptOfCase.WaterMarkFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(431, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 40);
            this.label12.TabIndex = 27;
            this.label12.Text = "نوع الحكم الصادر\r\nبشأن القضية:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbJudgmentOnTheCase
            // 
            this.cbJudgmentOnTheCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbJudgmentOnTheCase.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.casetblBindingSource, "JOCID", true));
            this.cbJudgmentOnTheCase.FormattingEnabled = true;
            this.cbJudgmentOnTheCase.ItemHeight = 23;
            this.cbJudgmentOnTheCase.Location = new System.Drawing.Point(35, 523);
            this.cbJudgmentOnTheCase.Name = "cbJudgmentOnTheCase";
            this.cbJudgmentOnTheCase.Size = new System.Drawing.Size(398, 29);
            this.cbJudgmentOnTheCase.TabIndex = 26;
            this.cbJudgmentOnTheCase.UseSelectable = true;
            // 
            // rcPlus
            // 
            this.rcPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rcPlus.Image = global::FouziaApp.Properties.Resources.plus1;
            this.rcPlus.ImageSize = 25;
            this.rcPlus.Location = new System.Drawing.Point(14, 183);
            this.rcPlus.Name = "rcPlus";
            this.rcPlus.Size = new System.Drawing.Size(28, 29);
            this.rcPlus.Style = MetroFramework.MetroColorStyle.Green;
            this.rcPlus.TabIndex = 47;
            this.rcPlus.UseSelectable = true;
            this.rcPlus.Click += new System.EventHandler(this.rcPlus_Click);
            // 
            // JOCPlus
            // 
            this.JOCPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.JOCPlus.Image = global::FouziaApp.Properties.Resources.plus1;
            this.JOCPlus.ImageSize = 25;
            this.JOCPlus.Location = new System.Drawing.Point(12, 521);
            this.JOCPlus.Name = "JOCPlus";
            this.JOCPlus.Size = new System.Drawing.Size(28, 29);
            this.JOCPlus.Style = MetroFramework.MetroColorStyle.Green;
            this.JOCPlus.TabIndex = 48;
            this.JOCPlus.UseSelectable = true;
            this.JOCPlus.Click += new System.EventHandler(this.JOCPlus_Click);
            // 
            // receiptOfCasetblBindingSource
            // 
            this.receiptOfCasetblBindingSource.DataSource = typeof(FouziaApp.receiptOfCase_tbl);
            // 
            // servicetblBindingSource
            // 
            this.servicetblBindingSource.DataSource = typeof(FouziaApp.service_tbl);
            // 
            // caseSubjecttblBindingSource
            // 
            this.caseSubjecttblBindingSource.DataSource = typeof(FouziaApp.caseSubject_tbl);
            // 
            // servicePlus
            // 
            this.servicePlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.servicePlus.Image = global::FouziaApp.Properties.Resources.plus1;
            this.servicePlus.ImageSize = 25;
            this.servicePlus.Location = new System.Drawing.Point(12, 97);
            this.servicePlus.Name = "servicePlus";
            this.servicePlus.Size = new System.Drawing.Size(28, 29);
            this.servicePlus.Style = MetroFramework.MetroColorStyle.Green;
            this.servicePlus.TabIndex = 49;
            this.servicePlus.UseSelectable = true;
            this.servicePlus.Click += new System.EventHandler(this.servicePlus_Click);
            // 
            // AddCase
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 685);
            this.Controls.Add(this.cbJudgmentOnTheCase);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRceiptOfCase);
            this.Controls.Add(this.txtPDFPath);
            this.Controls.Add(this.btnCaseFileUpload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbReceiptOfCase);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbCaseSubject);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDateOfReplyToTheExpert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDateOfTheExpertCall);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkFinished);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtJudgment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDateOfTheJudgment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDateOfTheReply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateOfTheOpenPetition);
            this.Controls.Add(this.txtCaseNum);
            this.Controls.Add(this.servicePlus);
            this.Controls.Add(this.rcPlus);
            this.Controls.Add(this.JOCPlus);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddCase";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "إضافة (تعديل) قضية";
            this.Load += new System.EventHandler(this.AddCase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCase_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddCase_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.casetblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptOfCasetblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicetblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseSubjecttblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCaseNum;
        private MetroFramework.Controls.MetroDateTime dtpDateOfTheOpenPetition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroDateTime dtpDateOfTheReply;
        private MetroFramework.Controls.MetroDateTime dtpDateOfTheJudgment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtJudgment;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroCheckBox chkFinished;
        private MetroFramework.Controls.MetroDateTime dtpDateOfTheExpertCall;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroDateTime dtpDateOfReplyToTheExpert;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroComboBox cbService;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroComboBox cbReceiptOfCase;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroLink btnSave;
        private System.Windows.Forms.BindingSource casetblBindingSource;
        private System.Windows.Forms.BindingSource caseSubjecttblBindingSource;
        private System.Windows.Forms.BindingSource servicetblBindingSource;
        private System.Windows.Forms.BindingSource receiptOfCasetblBindingSource;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroComboBox cbCaseSubject;
        private MetroFramework.Controls.MetroLink btnCaseFileUpload;
        private MetroFramework.Controls.MetroTextBox txtPDFPath;
        private MetroFramework.Controls.MetroTextBox txtRceiptOfCase;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroComboBox cbJudgmentOnTheCase;
        private MetroFramework.Controls.MetroLink rcPlus;
        private MetroFramework.Controls.MetroLink JOCPlus;
        private MetroFramework.Controls.MetroLink servicePlus;
    }
}