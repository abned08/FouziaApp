using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FouziaApp
{
    public partial class AddCase : MetroFramework.Forms.MetroForm
    {
        public AddCase(case_tbl case_)
        {
            InitializeComponent();
            casetblBindingSource.DataSource = case_;
            KeyPreview = true;
            if (chkFinished.CheckState == CheckState.Checked)
                chkFinished.Text = "منتهية";
            else
                chkFinished.Text = "غير منتهية";
        }

        public case_tbl caseInfo { get { return casetblBindingSource.Current as case_tbl; } }


        private void btnSave_Click(object sender, EventArgs e)
        {
            casetblBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void chkFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFinished.CheckState == CheckState.Checked)
                chkFinished.Text = "منتهية";
            else
                chkFinished.Text = "غير منتهية";
        }

        fouziaDBEntities db;
        private void AddCase_Load(object sender, EventArgs e)
        {
            cbService.DisplayMember = "serviceName";
            cbService.ValueMember = "serviceID";
            cbCaseSubject.DisplayMember = "csAdress";
            cbCaseSubject.ValueMember = "csID";
            cbReceiptOfCase.DisplayMember = "rcDate";
            cbReceiptOfCase.ValueMember = "rcID";
            cbJudgmentOnTheCase.DisplayMember = "JOCName";
            cbJudgmentOnTheCase.ValueMember = "JOCID";
            using (fouziaDBEntities db = new fouziaDBEntities())
            {
                cbCaseSubject.DataSource = db.caseSubject_tbl.ToList();
                cbService.DataSource = db.service_tbl.ToList();
                cbReceiptOfCase.DataSource = db.receiptOfCase_tbl.ToList();
                cbJudgmentOnTheCase.DataSource = db.judgmentOnTheCase_tbl.ToList();

                if (cbReceiptOfCase.SelectedIndex == -1)
                {
                    txtRceiptOfCase.Text = "";
                }
                else
                {
                    int s = Convert.ToInt32(cbReceiptOfCase.SelectedValue);
                    var receipt = db.receiptOfCase_tbl.Where(r => r.rcID == s).Single();
                    txtRceiptOfCase.Text = receipt.rcJudicialAuthority;
                }

            }
            if (caseInfo.serviceID != null && caseInfo.csID != null && caseInfo.rcID != null)
            {
                cbService.SelectedValue = caseInfo.serviceID;
                cbCaseSubject.SelectedValue = caseInfo.csID;
                cbReceiptOfCase.SelectedValue = caseInfo.rcID;

            }



        }

        private void btnCaseFileUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملف pdf |*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string source = ofd.FileName;
                string destination = Path.Combine(Environment.CurrentDirectory + "\\filesPDF", Path.GetFileName(ofd.FileName));
                File.Copy(ofd.FileName, destination, true);
                txtPDFPath.Text = destination;
            }
        }

        private void AddCase_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AddCase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                cbCaseSubject.SelectedIndex = -1;
                cbReceiptOfCase.SelectedIndex = -1;
                cbService.SelectedIndex = -1;
                txtCaseNum.Text = "";
                txtJudgment.Text = "";
                txtRceiptOfCase.Text = "";
                dtpDateOfTheOpenPetition.Value = DateTime.Now;
                dtpDateOfTheJudgment.Value = DateTime.Now;
                dtpDateOfTheExpertCall.Value = DateTime.Now;
                dtpDateOfReplyToTheExpert.Value = DateTime.Now;
                dtpDateOfTheReply.Value = DateTime.Now;
                chkFinished.Checked = false;
                txtPDFPath.Text = "";

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void cbReceiptOfCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(fouziaDBEntities db = new fouziaDBEntities())
            {
                if (cbReceiptOfCase.SelectedIndex == -1)
                {
                    txtRceiptOfCase.Text = "";
                }
                else
                {
                    int s = Convert.ToInt32(cbReceiptOfCase.SelectedValue);
                    var receipt = db.receiptOfCase_tbl.Where(r => r.rcID == s).Single();
                    txtRceiptOfCase.Text = receipt.rcJudicialAuthority;
                }

            }
        }

        private void JOCPlus_Click(object sender, EventArgs e)
        {
            using(frmAddJOC frm =new frmAddJOC())
            {
                using(db=new fouziaDBEntities())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        cbJudgmentOnTheCase.DataSource = db.judgmentOnTheCase_tbl.ToList();
                    }
                }
            }
        }

        private void rcPlus_Click(object sender, EventArgs e)
        {
            using (frmAddReceiptOfCase frm = new frmAddReceiptOfCase())
            {
                using (db = new fouziaDBEntities())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        cbReceiptOfCase.DataSource = db.receiptOfCase_tbl.ToList();
                    }
                }
            }
        }

        private void servicePlus_Click(object sender, EventArgs e)
        {
            using (frmAddService frm = new frmAddService())
            {
                using (db = new fouziaDBEntities())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        cbService.DataSource = db.service_tbl.ToList();
                    }
                }
            }
        }
    }
}
