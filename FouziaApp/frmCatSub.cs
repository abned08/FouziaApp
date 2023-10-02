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
    public partial class frmAddCatSub : MetroFramework.Forms.MetroForm
    {
        public frmAddCatSub()
        {
            InitializeComponent();
        }


        fouziaDBEntities fdb;
        private void frmCatSub_Load(object sender, EventArgs e)
        {
            using (fdb = new fouziaDBEntities())
            {
                catSubtblBindingSource.DataSource = fdb.catSub_tbl.ToList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            catSubtblBindingSource.EndEdit();
            DialogResult = DialogResult.OK;

        }

        private void addCatSub_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = true;
            catSubtblBindingSource.Add(new catSub_tbl());
            catSubtblBindingSource.MoveLast();
        }

        private void btnAddToContext_Click(object sender, EventArgs e)
        {
            catSub_tbl _Tbl = catSubtblBindingSource.Current as catSub_tbl;

            using (fdb = new fouziaDBEntities())
            {

                if (_Tbl.catSubID == 0)
                {
                    try
                    {
                        fdb.Entry<catSub_tbl>(_Tbl).State = System.Data.Entity.EntityState.Added;
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
                        catSub_tbl cat = new catSub_tbl { catSubID = _Tbl.catSubID, catSubName = _Tbl.catSubName };
                        fdb.Entry<catSub_tbl>(cat).State = System.Data.Entity.EntityState.Modified;
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
            catSub_tbl obj = catSubtblBindingSource.Current as catSub_tbl;
            using (fdb = new fouziaDBEntities())
            {
                if (obj != null)
                {
                    try
                    {
                        if (fdb.Entry(obj).State == EntityState.Detached)
                            fdb.Set<catSub_tbl>().Attach(obj);
                        fdb.Entry(obj).State = EntityState.Deleted;
                        catSubtblBindingSource.RemoveCurrent();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                fdb.SaveChanges();

            }
            metroPanel.Enabled = false;
        }

        private void dgvCatSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metroPanel.Enabled = true;
        }

        private void txtSearchCatSub_TextChanged(object sender, EventArgs e)
        {
            using (fdb = new fouziaDBEntities())
            {
                if (txtSearchCatSub.Text != "")
                {
                    var result = (from c in fdb.catSub_tbl.DefaultIfEmpty()
                                  where c.catSubName.Contains(txtSearchCatSub.Text)
                                  select c).ToList();
                    catSubtblBindingSource.DataSource = result;

                }

            }
        }
    }
}
