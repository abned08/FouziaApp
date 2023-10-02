﻿namespace FouziaApp
{
    partial class frmAddAppealToTheSupremeCourt
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
            this.txtJudgeOfAppeal = new MetroFramework.Controls.MetroTextBox();
            this.appealSupremeCourttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtReportNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtpDateOfReport = new MetroFramework.Controls.MetroDateTime();
            this.txtAppealNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpDateOfAppeal = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.appealSupremeCourttblBindingSource)).BeginInit();
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
            this.btnSave.Location = new System.Drawing.Point(156, 536);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = global::FouziaApp.Properties.Resources.save;
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "حـــــــفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtJudgeOfAppeal
            // 
            this.txtJudgeOfAppeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtJudgeOfAppeal.CustomButton.Image = null;
            this.txtJudgeOfAppeal.CustomButton.Location = new System.Drawing.Point(84, 1);
            this.txtJudgeOfAppeal.CustomButton.Name = "";
            this.txtJudgeOfAppeal.CustomButton.Size = new System.Drawing.Size(205, 205);
            this.txtJudgeOfAppeal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJudgeOfAppeal.CustomButton.TabIndex = 1;
            this.txtJudgeOfAppeal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJudgeOfAppeal.CustomButton.UseSelectable = true;
            this.txtJudgeOfAppeal.CustomButton.Visible = false;
            this.txtJudgeOfAppeal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appealSupremeCourttblBindingSource, "judgmentOfAppeal", true));
            this.txtJudgeOfAppeal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtJudgeOfAppeal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtJudgeOfAppeal.Lines = new string[0];
            this.txtJudgeOfAppeal.Location = new System.Drawing.Point(12, 312);
            this.txtJudgeOfAppeal.MaxLength = 32767;
            this.txtJudgeOfAppeal.Multiline = true;
            this.txtJudgeOfAppeal.Name = "txtJudgeOfAppeal";
            this.txtJudgeOfAppeal.PasswordChar = '\0';
            this.txtJudgeOfAppeal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJudgeOfAppeal.SelectedText = "";
            this.txtJudgeOfAppeal.SelectionLength = 0;
            this.txtJudgeOfAppeal.SelectionStart = 0;
            this.txtJudgeOfAppeal.ShortcutsEnabled = true;
            this.txtJudgeOfAppeal.Size = new System.Drawing.Size(290, 207);
            this.txtJudgeOfAppeal.TabIndex = 4;
            this.txtJudgeOfAppeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJudgeOfAppeal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtJudgeOfAppeal.UseSelectable = true;
            this.txtJudgeOfAppeal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJudgeOfAppeal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // appealSupremeCourttblBindingSource
            // 
            this.appealSupremeCourttblBindingSource.DataSource = typeof(FouziaApp.appealSupremeCourt_tbl);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(319, 316);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(130, 25);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = ": حكم الاستئناف";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtReportNum
            // 
            this.txtReportNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtReportNum.CustomButton.Image = null;
            this.txtReportNum.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.txtReportNum.CustomButton.Name = "";
            this.txtReportNum.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtReportNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReportNum.CustomButton.TabIndex = 1;
            this.txtReportNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReportNum.CustomButton.UseSelectable = true;
            this.txtReportNum.CustomButton.Visible = false;
            this.txtReportNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appealSupremeCourttblBindingSource, "reportNum", true));
            this.txtReportNum.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtReportNum.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtReportNum.Lines = new string[0];
            this.txtReportNum.Location = new System.Drawing.Point(209, 262);
            this.txtReportNum.MaxLength = 32767;
            this.txtReportNum.Multiline = true;
            this.txtReportNum.Name = "txtReportNum";
            this.txtReportNum.PasswordChar = '\0';
            this.txtReportNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtReportNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReportNum.SelectedText = "";
            this.txtReportNum.SelectionLength = 0;
            this.txtReportNum.SelectionStart = 0;
            this.txtReportNum.ShortcutsEnabled = true;
            this.txtReportNum.Size = new System.Drawing.Size(93, 33);
            this.txtReportNum.TabIndex = 3;
            this.txtReportNum.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtReportNum.UseSelectable = true;
            this.txtReportNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReportNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(319, 266);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 25);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = ": رقم التقرير";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(319, 215);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(115, 25);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = ": تاريخ التقرير";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpDateOfReport
            // 
            this.dtpDateOfReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfReport.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appealSupremeCourttblBindingSource, "dateOfReoprt", true));
            this.dtpDateOfReport.DisplayFocus = true;
            this.dtpDateOfReport.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateOfReport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfReport.Location = new System.Drawing.Point(36, 212);
            this.dtpDateOfReport.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateOfReport.Name = "dtpDateOfReport";
            this.dtpDateOfReport.Size = new System.Drawing.Size(266, 29);
            this.dtpDateOfReport.TabIndex = 2;
            this.dtpDateOfReport.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAppealNum
            // 
            this.txtAppealNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAppealNum.CustomButton.Image = null;
            this.txtAppealNum.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.txtAppealNum.CustomButton.Name = "";
            this.txtAppealNum.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtAppealNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAppealNum.CustomButton.TabIndex = 1;
            this.txtAppealNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAppealNum.CustomButton.UseSelectable = true;
            this.txtAppealNum.CustomButton.Visible = false;
            this.txtAppealNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appealSupremeCourttblBindingSource, "appealNum", true));
            this.txtAppealNum.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAppealNum.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtAppealNum.Lines = new string[0];
            this.txtAppealNum.Location = new System.Drawing.Point(209, 149);
            this.txtAppealNum.MaxLength = 32767;
            this.txtAppealNum.Multiline = true;
            this.txtAppealNum.Name = "txtAppealNum";
            this.txtAppealNum.PasswordChar = '\0';
            this.txtAppealNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAppealNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAppealNum.SelectedText = "";
            this.txtAppealNum.SelectionLength = 0;
            this.txtAppealNum.SelectionStart = 0;
            this.txtAppealNum.ShortcutsEnabled = true;
            this.txtAppealNum.Size = new System.Drawing.Size(93, 33);
            this.txtAppealNum.TabIndex = 1;
            this.txtAppealNum.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAppealNum.UseSelectable = true;
            this.txtAppealNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAppealNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(319, 153);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 25);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = ": رقم الاستئناف";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(319, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(137, 25);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = ": تاريخ الاستئناف";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpDateOfAppeal
            // 
            this.dtpDateOfAppeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfAppeal.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appealSupremeCourttblBindingSource, "dateOfAppeal", true));
            this.dtpDateOfAppeal.DisplayFocus = true;
            this.dtpDateOfAppeal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateOfAppeal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfAppeal.Location = new System.Drawing.Point(36, 99);
            this.dtpDateOfAppeal.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateOfAppeal.Name = "dtpDateOfAppeal";
            this.dtpDateOfAppeal.Size = new System.Drawing.Size(266, 29);
            this.dtpDateOfAppeal.TabIndex = 0;
            this.dtpDateOfAppeal.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmAddAppealToTheSupremeCourt
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 602);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtJudgeOfAppeal);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtReportNum);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dtpDateOfReport);
            this.Controls.Add(this.txtAppealNum);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtpDateOfAppeal);
            this.MaximizeBox = false;
            this.Name = "frmAddAppealToTheSupremeCourt";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "إضافة (تعديل) استئناف";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.appealSupremeCourttblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroTextBox txtJudgeOfAppeal;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtReportNum;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime dtpDateOfReport;
        private MetroFramework.Controls.MetroTextBox txtAppealNum;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtpDateOfAppeal;
        private System.Windows.Forms.BindingSource appealSupremeCourttblBindingSource;
    }
}