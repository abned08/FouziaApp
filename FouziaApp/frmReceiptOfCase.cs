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
    public partial class frmAddReceiptOfCase : MetroFramework.Forms.MetroForm
    {
        public frmAddReceiptOfCase()
        {
            InitializeComponent();
        }


        fouziaDBEntities fdb;
        private void frmReceiptOfCase_Load(object sender, EventArgs e)
        {
            using (fdb = new fouziaDBEntities())
            {
                receiptOfCasetblBindingSource.DataSource = fdb.receiptOfCase_tbl.ToList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            receiptOfCasetblBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void addRC_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = true;
            receiptOfCasetblBindingSource.Add(new receiptOfCase_tbl());
            receiptOfCasetblBindingSource.MoveLast();
        }

        private void btnAddToContext_Click(object sender, EventArgs e)
        {
            receiptOfCase_tbl _Tbl = receiptOfCasetblBindingSource.Current as receiptOfCase_tbl;

            using (fdb = new fouziaDBEntities())
            {

                if (_Tbl.rcID == 0)
                {
                    try
                    {
                        fdb.Entry<receiptOfCase_tbl>(_Tbl).State = System.Data.Entity.EntityState.Added;
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
                        receiptOfCase_tbl cat = new receiptOfCase_tbl { rcID = _Tbl.rcID, rcDate = _Tbl.rcDate,rcJudicialAuthority=_Tbl.rcJudicialAuthority };
                        fdb.Entry<receiptOfCase_tbl>(cat).State = System.Data.Entity.EntityState.Modified;
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
            receiptOfCase_tbl obj = receiptOfCasetblBindingSource.Current as receiptOfCase_tbl;
            using (fdb = new fouziaDBEntities())
            {
                if (obj != null)
                {
                    try
                    {
                        if (fdb.Entry(obj).State == EntityState.Detached)
                            fdb.Set<receiptOfCase_tbl>().Attach(obj);
                        fdb.Entry(obj).State = EntityState.Deleted;
                        receiptOfCasetblBindingSource.RemoveCurrent();
                        fdb.SaveChanges();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                    {

                        MessageBox.Show("لا يمكنك حذف هذه الجهة القضائية إلا بعد حذف القضايا التابعة لها");
                    }
                }
                

            }
            metroPanel.Enabled = false;
        }

        private void dgvRC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metroPanel.Enabled = true;
        }

        private void txtSearchRC_TextChanged(object sender, EventArgs e)
        {
            using (fdb = new fouziaDBEntities())
            {
                if (txtSearchRC.Text != "")
                {
                    var result = (from c in fdb.receiptOfCase_tbl.DefaultIfEmpty()
                                  where c.rcJudicialAuthority.Contains(txtSearchRC.Text)
                                  select c).ToList();
                    receiptOfCasetblBindingSource.DataSource = result;

                }

            }
        }
    }
}
