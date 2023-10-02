using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FouziaApp
{
    public partial class frmAddCaseSubj : MetroFramework.Forms.MetroForm
    {
        public frmAddCaseSubj(caseSubject_tbl caseSubject)
        {
            InitializeComponent();
            caseSubjecttblBindingSource.DataSource = caseSubject;
        }

        public caseSubject_tbl caseSubjInfo { get { return caseSubjecttblBindingSource.Current as caseSubject_tbl; } }

        private void btnSave_Click(object sender, EventArgs e)
        {
            caseSubjecttblBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
        fouziaDBEntities db;
        private void frmAddCaseSubj_Load(object sender, EventArgs e)
        {
            cbRecordNum.DisplayMember = "recordNum";
            cbRecordNum.ValueMember = "recordID";
            cbCatSub.DisplayMember = "catSubName";
            cbCatSub.ValueMember = "catSubID";
            using (fouziaDBEntities db = new fouziaDBEntities())
            {
                cbRecordNum.DataSource = db.record_tbl.ToList();
                cbCatSub.DataSource = db.catSub_tbl.ToList();

            }

            if (caseSubjInfo.recordID != null)
                cbRecordNum.SelectedValue = caseSubjInfo.recordID;
            else
                cbRecordNum.SelectedIndex = -1;

            if (caseSubjInfo.catSubID != null)
                cbCatSub.SelectedValue = caseSubjInfo.catSubID;
            else
                cbCatSub.SelectedIndex = -1;

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void recordPlus_Click(object sender, EventArgs e)
        {
            using(frmAddRecord frm=new frmAddRecord())
            {
                using(db=new fouziaDBEntities())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        cbRecordNum.DataSource = db.record_tbl.ToList();
                    }

                }
            }
        }

        private void catSubPlus_Click(object sender, EventArgs e)
        {
            using (frmAddCatSub frm = new frmAddCatSub())
            {
                using (db = new fouziaDBEntities())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        cbCatSub.DataSource = db.catSub_tbl.ToList();
                    }

                }
            }
        }
    }
}
