using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FouziaApp
{
    public partial class ucStatistics : UserControl
    {
        public ucStatistics()
        {
            InitializeComponent();
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMain.Instance.MetroContainer.Controls["ucDisputes"].BringToFront();
        }

        private void btnJudgmentAuthority_Click(object sender, EventArgs e)
        {
            frmStatJudgmentAuthority frm = new frmStatJudgmentAuthority();
            frm.ShowDialog();
        }

        private void btnCaseSubject_Click(object sender, EventArgs e)
        {
            frmStatCatSub frm = new frmStatCatSub();
            frm.ShowDialog();
        }

        private void btnAppeal_Click(object sender, EventArgs e)
        {
            frmStatAppeal frm = new frmStatAppeal();
            frm.ShowDialog();
        }

        private void btnJudgmentOnTheCase_Click(object sender, EventArgs e)
        {
            frmStatJudgmentOnTheCase frm = new frmStatJudgmentOnTheCase();
            frm.ShowDialog();
        }
    }
}
