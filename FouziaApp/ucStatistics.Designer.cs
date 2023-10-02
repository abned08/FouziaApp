namespace FouziaApp
{
    partial class ucStatistics
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
            this.btnAppeal = new MetroFramework.Controls.MetroLink();
            this.btnJudgmentOnTheCase = new MetroFramework.Controls.MetroLink();
            this.btnCaseSubject = new MetroFramework.Controls.MetroLink();
            this.btnJudgmentAuthority = new MetroFramework.Controls.MetroLink();
            this.mtBack = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // btnAppeal
            // 
            this.btnAppeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAppeal.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnAppeal.Image = global::FouziaApp.Properties.Resources.appeal;
            this.btnAppeal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAppeal.ImageSize = 150;
            this.btnAppeal.Location = new System.Drawing.Point(37, 105);
            this.btnAppeal.Name = "btnAppeal";
            this.btnAppeal.Size = new System.Drawing.Size(223, 203);
            this.btnAppeal.TabIndex = 24;
            this.btnAppeal.Text = "القضايا محل استئناف\r\nوطعن بالنقض";
            this.btnAppeal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAppeal.UseSelectable = true;
            this.btnAppeal.Click += new System.EventHandler(this.btnAppeal_Click);
            // 
            // btnJudgmentOnTheCase
            // 
            this.btnJudgmentOnTheCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJudgmentOnTheCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJudgmentOnTheCase.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnJudgmentOnTheCase.Image = global::FouziaApp.Properties.Resources.verdict;
            this.btnJudgmentOnTheCase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJudgmentOnTheCase.ImageSize = 150;
            this.btnJudgmentOnTheCase.Location = new System.Drawing.Point(266, 105);
            this.btnJudgmentOnTheCase.Name = "btnJudgmentOnTheCase";
            this.btnJudgmentOnTheCase.Size = new System.Drawing.Size(223, 203);
            this.btnJudgmentOnTheCase.TabIndex = 23;
            this.btnJudgmentOnTheCase.Text = "القضايا التي صدرت\r\n بشأنها أحكام";
            this.btnJudgmentOnTheCase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJudgmentOnTheCase.UseSelectable = true;
            this.btnJudgmentOnTheCase.Click += new System.EventHandler(this.btnJudgmentOnTheCase_Click);
            // 
            // btnCaseSubject
            // 
            this.btnCaseSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaseSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCaseSubject.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnCaseSubject.Image = global::FouziaApp.Properties.Resources.subject;
            this.btnCaseSubject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCaseSubject.ImageSize = 150;
            this.btnCaseSubject.Location = new System.Drawing.Point(495, 105);
            this.btnCaseSubject.Name = "btnCaseSubject";
            this.btnCaseSubject.Size = new System.Drawing.Size(223, 203);
            this.btnCaseSubject.TabIndex = 22;
            this.btnCaseSubject.Text = "موضـــوع الدعـــوى";
            this.btnCaseSubject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCaseSubject.UseSelectable = true;
            this.btnCaseSubject.Click += new System.EventHandler(this.btnCaseSubject_Click);
            // 
            // btnJudgmentAuthority
            // 
            this.btnJudgmentAuthority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJudgmentAuthority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJudgmentAuthority.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnJudgmentAuthority.Image = global::FouziaApp.Properties.Resources.judgment_Authority;
            this.btnJudgmentAuthority.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJudgmentAuthority.ImageSize = 150;
            this.btnJudgmentAuthority.Location = new System.Drawing.Point(724, 105);
            this.btnJudgmentAuthority.Name = "btnJudgmentAuthority";
            this.btnJudgmentAuthority.Size = new System.Drawing.Size(223, 203);
            this.btnJudgmentAuthority.TabIndex = 21;
            this.btnJudgmentAuthority.Text = "الجهـــــــة القضائيــــــــة";
            this.btnJudgmentAuthority.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJudgmentAuthority.UseSelectable = true;
            this.btnJudgmentAuthority.Click += new System.EventHandler(this.btnJudgmentAuthority_Click);
            // 
            // mtBack
            // 
            this.mtBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBack.DisplayFocus = true;
            this.mtBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mtBack.Image = global::FouziaApp.Properties.Resources.back1;
            this.mtBack.ImageSize = 40;
            this.mtBack.Location = new System.Drawing.Point(925, 13);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(49, 52);
            this.mtBack.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtBack.TabIndex = 25;
            this.mtBack.UseCustomBackColor = true;
            this.mtBack.UseCustomForeColor = true;
            this.mtBack.UseSelectable = true;
            this.mtBack.UseStyleColors = true;
            this.mtBack.Click += new System.EventHandler(this.mtBack_Click);
            // 
            // ucStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.btnAppeal);
            this.Controls.Add(this.btnJudgmentOnTheCase);
            this.Controls.Add(this.btnCaseSubject);
            this.Controls.Add(this.btnJudgmentAuthority);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucStatistics";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(991, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink btnJudgmentAuthority;
        private MetroFramework.Controls.MetroLink btnCaseSubject;
        private MetroFramework.Controls.MetroLink btnJudgmentOnTheCase;
        private MetroFramework.Controls.MetroLink btnAppeal;
        private MetroFramework.Controls.MetroLink mtBack;
    }
}
