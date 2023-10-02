using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace FouziaApp
{
    public partial class UcCases : MetroFramework.Controls.MetroUserControl
    {
        public UcCases(caseSubject_tbl obj)
        {
            InitializeComponent();
            caseSubjectbindingSource.DataSource = obj;

        }
        public caseSubject_tbl caseSubject { get { return caseSubjectbindingSource.Current as caseSubject_tbl; } }
        //public case_tbl Case_ { get { return casetblBindingSource.Current as case_tbl; } }

        fouziaDBEntities fdb;
        private void UcCases_Load(object sender, EventArgs e)
        {


            fdb = new fouziaDBEntities();

            var caseSub = (from c in fdb.case_tbl
                           where c.csID == caseSubject.csID
                           select c).ToList();
            var rec = fdb.record_tbl.Where(r => r.recordID == caseSubject.recordID).Select(r => r.recordNum).FirstOrDefault();
            if (rec != null)
                txtRecord.Text = rec.ToString();
            casetblBindingSource.DataSource = caseSub.ToList();
            recordtblBindingSource.DataSource = fdb.record_tbl.ToList();
            servicetblBindingSource.DataSource = fdb.service_tbl.ToList();
            caseSubjectbindingSource.DataSource = fdb.caseSubject_tbl.ToList();



        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMain.Instance.MetroContainer.Controls["ucDisputes"].BringToFront();
        }

        private void mtDgvCaseSubject_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void mtDgvCaseSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mtDgvCaseSubject.Rows.Count==0)
            {
                return;
            }
            case_tbl Case_ = casetblBindingSource.Current as case_tbl;

            if (Case_.serviceID != null)
                txtService.Text = Case_.service_tbl.serviceName.ToString();
            if (Case_.csID != null)
                txtCaseSubj.Text = Case_.caseSubject_tbl.csAdress.ToString();


            var selectCouncil = fdb.appealCouncilOfState_tbl.Where(c => c.caseID == Case_.caseID).ToList();
            var selectSepreme = fdb.appealSupremeCourt_tbl.Where(x => x.caseID == Case_.caseID).ToList();
            if (selectCouncil != null)
            {
                appealCouncilOfStatetblBindingSource.DataSource = selectCouncil;
                dgvAppealToTheCouncil.Visible = true;

            }
            else
            {
                dgvAppealToTheCouncil.Visible = false;
            }
            if (selectSepreme != null)
            {
                appealSupremeCourttblBindingSource.DataSource = selectSepreme;
                dgvAppealToSpepremeCourt.Visible = true;
            }
            else
            {
                dgvAppealToSpepremeCourt.Visible = false;
            }


        }

        private void casePlus_Click(object sender, EventArgs e)
        {
            using (AddCase addCase = new AddCase(new case_tbl() { finished = false }))
            {
                if (addCase.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        casetblBindingSource.Add(addCase.caseInfo);
                        fdb.case_tbl.Add(addCase.caseInfo);
                        fdb.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mtDgvCaseSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "هل أنت متأكد من الحذف", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int rows = mtDgvCaseSubject.RowCount;
                        for (int i = rows - 1; i >= 0; i--)
                        {
                            if (mtDgvCaseSubject.Rows[i].Selected)
                            {
                                fdb.case_tbl.Remove(mtDgvCaseSubject.Rows[i].DataBoundItem as case_tbl);
                                casetblBindingSource.RemoveAt(mtDgvCaseSubject.Rows[i].Index);
                                fdb.SaveChanges();

                            }
                        }

                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {

                        MessageBox.Show("لا يمكن حذف هذه القضية إلا بعد حذف الجداول بالأسفل التابعة لها");
                    }

                }

            }
        }

        private void mtDgvCaseSubject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mtDgvCaseSubject.Rows.Count==0)
            {
                return;
            }
            case_tbl case__ = casetblBindingSource.Current as case_tbl;
            if (case__ != null)
            {
                using (AddCase edit = new AddCase(case__))
                {


                    if (edit.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            casetblBindingSource.EndEdit();
                            fdb.SaveChanges();
                            mtDgvCaseSubject.ClearSelection();
                            txtService.Text = "";
                            txtCaseSubj.Text = "";
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void plusAppealToTheCouncil_Click(object sender, EventArgs e)
        {
            //int rowID = Convert.ToInt32(mtDgvCaseSubject.CurrentRow.Cells["caseID"].Value);
            case_tbl dase_ = casetblBindingSource.Current as case_tbl;

            using (frmAddAppealToTheCouncil addCouncil = new frmAddAppealToTheCouncil(new appealCouncilOfState_tbl()))
            {
                if (addCouncil.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //case_tbl xase_ = fdb.case_tbl.FirstOrDefault(c => c.caseID == rowID);
                        dase_.appealCouncilOfState_tbl.Add(addCouncil.councilInfo);
                        //xase_.appealCouncilOfState_tbl.Add(addCouncil.councilInfo);
                        appealCouncilOfStatetblBindingSource.Add(addCouncil.councilInfo);
                        fdb.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void dgvAppealToTheCouncil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            appealCouncilOfState_tbl appealCouncil = appealCouncilOfStatetblBindingSource.Current as appealCouncilOfState_tbl;
            if (appealCouncil != null)
            {
                using (frmAddAppealToTheCouncil add = new frmAddAppealToTheCouncil(appealCouncil))
                {
                    if (add.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            appealCouncilOfStatetblBindingSource.EndEdit();
                            fdb.SaveChanges();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void dgvAppealToTheCouncil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "هل أنت متأكد من الحذف", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rows = dgvAppealToTheCouncil.RowCount;
                    for (int i = rows - 1; i >= 0; i--)
                    {
                        if (dgvAppealToTheCouncil.Rows[i].Selected)
                        {
                            fdb.appealCouncilOfState_tbl.Remove(dgvAppealToTheCouncil.Rows[i].DataBoundItem as appealCouncilOfState_tbl);
                            appealCouncilOfStatetblBindingSource.RemoveAt(dgvAppealToTheCouncil.Rows[i].Index);
                            fdb.SaveChanges();

                        }
                    }

                }

            }
        }

        private void plusAppealToSpepremeCourt_Click(object sender, EventArgs e)
        {
            case_tbl dase_ = casetblBindingSource.Current as case_tbl;

            using (frmAddAppealToTheSupremeCourt addSupreme = new frmAddAppealToTheSupremeCourt(new appealSupremeCourt_tbl()))
            {
                if (addSupreme.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //case_tbl xase_ = fdb.case_tbl.FirstOrDefault(c => c.caseID == rowID);
                        dase_.appealSupremeCourt_tbl.Add(addSupreme.supremeInfo);
                        //xase_.appealCouncilOfState_tbl.Add(addCouncil.councilInfo);
                        appealSupremeCourttblBindingSource.Add(addSupreme.supremeInfo);
                        fdb.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void dgvAppealToSpepremeCourt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            appealSupremeCourt_tbl appealSupreme = appealSupremeCourttblBindingSource.Current as appealSupremeCourt_tbl;
            if (appealSupreme != null)
            {
                using (frmAddAppealToTheSupremeCourt add = new frmAddAppealToTheSupremeCourt(appealSupreme))
                {
                    if (add.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            appealSupremeCourttblBindingSource.EndEdit();
                            fdb.SaveChanges();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void dgvAppealToSpepremeCourt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "هل أنت متأكد من الحذف", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rows = dgvAppealToSpepremeCourt.RowCount;
                    for (int i = rows - 1; i >= 0; i--)
                    {
                        if (dgvAppealToSpepremeCourt.Rows[i].Selected)
                        {
                            fdb.appealSupremeCourt_tbl.Remove(dgvAppealToSpepremeCourt.Rows[i].DataBoundItem as appealSupremeCourt_tbl);
                            appealSupremeCourttblBindingSource.RemoveAt(dgvAppealToSpepremeCourt.Rows[i].Index);
                            fdb.SaveChanges();

                        }
                    }

                }

            }
        }

        private void mtDgvCaseSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mtDgvCaseSubject.Columns[e.ColumnIndex].Name == "pdf")
            {
                case_tbl ccase_ = casetblBindingSource.Current as case_tbl;
                if (ccase_.filePath != null)
                {
                    try
                    {
                        Process p = new Process();
                        p.StartInfo.FileName = (ccase_.filePath).ToString();
                        p.Start();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("يبدو أن الملف غير موجود");
                    }

                }
                else
                {
                    MessageBox.Show("لم يتم تحديد ملف لهذه القضية بعد !");
                }

            }
        }
    }
}
