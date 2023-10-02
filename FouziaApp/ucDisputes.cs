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
    public partial class ucDisputes : MetroFramework.Controls.MetroUserControl
    {
        public ucDisputes()
        {
            InitializeComponent();
        }
        fouziaDBEntities db;
        private void ucDisputes_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPerson.Text != "")

            {
                Cursor.Current = Cursors.WaitCursor;
                using (fouziaDBEntities db = new fouziaDBEntities())
                {
                    String pr = txtPerson.Text;
                    var select =
                         (from p in db.persons_tbl.DefaultIfEmpty()
                          join cs in db.caseSubject_tbl on p.csID equals cs.csID
                          join ptc in db.partiesToTheConflict_tbl on p.PTCID equals ptc.PTCID
                          where p.personName.Contains(pr) || cs.csAdress.Contains(pr)
                          select new { p.personName, cs.csAdress, ptc.PTCName, cs.csSec, cs.csIlot, cs.csLot, cs.csTown }).ToList();

                    personstblBindingSource.DataSource = select;
                    caseSubjectBindingSource.DataSource = db.caseSubject_tbl.ToList();
                    partiesToTheConflicttblBindingSource.DataSource = db.partiesToTheConflict_tbl.ToList();
                    mtdgvPerson.DataSource = select;
                    mtdgvPerson.Visible = true;
                    Cursor.Current = Cursors.Default;
                }

            }
            else
            {
                mtdgvPerson.Visible = false;
            }

        }

        private void mtdgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            String casesbj = mtdgvPerson.CurrentRow.Cells["caseSubject_tbl"].Value.ToString();

            if (casesbj != null)
            {
                using (fouziaDBEntities db = new fouziaDBEntities())
                {
                    var selectSubj = (from s in db.caseSubject_tbl
                                      where s.csAdress == casesbj
                                      select s).FirstOrDefault();

                    if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("UcCases"))
                    {
                        UcCases ucase = new UcCases(selectSubj);
                        ucase.Dock = DockStyle.Fill;
                        frmMain.Instance.MetroContainer.Controls.Add(ucase);
                    }
                    frmMain.Instance.MetroContainer.Controls["UcCases"].BringToFront();

                }
            }
            Cursor.Current = Cursors.Default;

        }

        private void addCaseSubj_Click(object sender, EventArgs e)
        {
            using (db = new fouziaDBEntities())
            {
                using (frmAddCaseSubj addCaseSubj = new frmAddCaseSubj(new caseSubject_tbl()))
                {
                    if (addCaseSubj.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            caseSubjectBindingSource.Add(addCaseSubj.caseSubjInfo);
                            db.caseSubject_tbl.Add(addCaseSubj.caseSubjInfo);
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        private void mtdgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void mtdgvPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "سيتم حذف موضوع القضية، هل أنت متأكد؟", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (db=new fouziaDBEntities())
                        {
                            String casesbj = mtdgvPerson.CurrentRow.Cells["caseSubject_tbl"].Value.ToString();
                            var selectSubj1 = (from s in db.caseSubject_tbl
                                              where s.csAdress == casesbj
                                              select s).FirstOrDefault();
                            db.Entry(selectSubj1).State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();

                            txtPerson.Text = "";

                        }
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException )
                    {

                        MessageBox.Show("لا يمكنك حذف هذا الموضوع إلا بعد حذف القضايا التابعة له والأشخاص التابعين له");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }

            }
        }


        private void mtdgvPerson_MouseUp(object sender, MouseEventArgs e)
        {
            if (mtdgvPerson.Rows.Count==0)
            {
                return;
            }
            String casesbj = mtdgvPerson.CurrentRow.Cells["caseSubject_tbl"].Value.ToString();

            if (e.Button == MouseButtons.Right)
            {
                if (casesbj != null)
                {
                    using (fouziaDBEntities fdb = new fouziaDBEntities())
                    {
                        var selectSubj = (from s in fdb.caseSubject_tbl
                                          where s.csAdress == casesbj
                                          select s).FirstOrDefault();
                        using (frmAddCaseSubj add = new frmAddCaseSubj(selectSubj))
                        {
                            if (add.ShowDialog() == DialogResult.OK)
                            {
                                try
                                {
                                    caseSubjectBindingSource.EndEdit();
                                    fdb.SaveChanges();
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }

                    }
                    txtPerson.Text = "";
                }

            }
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            frmAddPerson addPerson = new frmAddPerson();
            addPerson.ShowDialog();

            //if (addPerson.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        personstblBindingSource.Add(addPerson.personInfo);
            //        db.persons_tbl.Add(addPerson.personInfo);
            //        db.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}




        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucStatistics"))
            {
                ucStatistics ucase = new ucStatistics();
                ucase.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(ucase);
            }
            frmMain.Instance.MetroContainer.Controls["ucStatistics"].BringToFront();
        }

       
    }
}
