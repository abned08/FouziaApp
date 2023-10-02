using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FouziaApp
{
    public partial class frmAddJOC : MetroFramework.Forms.MetroForm
    {
        public frmAddJOC()
        {
            InitializeComponent();
        }


        fouziaDBEntities fdb;
        private void frmAddJOC_Load(object sender, EventArgs e)
        {
            using (fdb = new fouziaDBEntities())
            {
                judgmentOnTheCasetblBindingSource.DataSource = fdb.judgmentOnTheCase_tbl.ToList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            judgmentOnTheCasetblBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void addJOC_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = true;
            judgmentOnTheCasetblBindingSource.Add(new judgmentOnTheCase_tbl());
            judgmentOnTheCasetblBindingSource.MoveLast();
        }

        private void btnAddToContext_Click(object sender, EventArgs e)
        {
            judgmentOnTheCase_tbl _Tbl = judgmentOnTheCasetblBindingSource.Current as judgmentOnTheCase_tbl;

            using (fdb = new fouziaDBEntities())
            {

                if (_Tbl.JOCID == 0)
                {
                    try
                    {
                        fdb.Entry<judgmentOnTheCase_tbl>(_Tbl).State = System.Data.Entity.EntityState.Added;
                        fdb.SaveChanges();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    try
                    {
                        judgmentOnTheCase_tbl cat = new judgmentOnTheCase_tbl { JOCID = _Tbl.JOCID, JOCName = _Tbl.JOCName };
                        fdb.Entry<judgmentOnTheCase_tbl>(cat).State = System.Data.Entity.EntityState.Modified;
                        fdb.SaveChanges();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

            }
            metroPanel.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            judgmentOnTheCase_tbl obj = judgmentOnTheCasetblBindingSource.Current as judgmentOnTheCase_tbl;
            using (fdb = new fouziaDBEntities())
            {
                if (obj != null)
                {
                    try
                    {
                        if (fdb.Entry(obj).State == EntityState.Detached)
                            fdb.Set<judgmentOnTheCase_tbl>().Attach(obj);
                        fdb.Entry(obj).State = EntityState.Deleted;
                        judgmentOnTheCasetblBindingSource.RemoveCurrent();
                        fdb.SaveChanges();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {

                        MessageBox.Show("لا يمكنك حذف هذا الحكم إلا بعد حذف القضايا التابعة له");
                    }
                }
                

            }
            metroPanel.Enabled = false;
        }

        private void dgvJOC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metroPanel.Enabled = true;
        }

        private void txtSearchJOC_TextChanged(object sender, EventArgs e)
        {
            using (fdb = new fouziaDBEntities())
            {
                if (txtSearchJOC.Text != "")
                {
                    var result = (from c in fdb.judgmentOnTheCase_tbl.DefaultIfEmpty()
                                  where c.JOCName.Contains(txtSearchJOC.Text)
                                  select c).ToList();
                    judgmentOnTheCasetblBindingSource.DataSource = result;

                }

            }
        }
    }
}
