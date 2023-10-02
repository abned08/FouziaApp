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
    public partial class frmAddService : MetroFramework.Forms.MetroForm
    {
        public frmAddService()
        {
            InitializeComponent();
        }


        fouziaDBEntities fdb;
        private void frmAddService_Load(object sender, EventArgs e)
        {
            using (fdb = new fouziaDBEntities())
            {
                servicetblBindingSource.DataSource = fdb.service_tbl.ToList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            servicetblBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void addService_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = true;
            servicetblBindingSource.Add(new service_tbl());
            servicetblBindingSource.MoveLast();
        }

        private void btnAddToContext_Click(object sender, EventArgs e)
        {
            service_tbl _Tbl = servicetblBindingSource.Current as service_tbl;

            using (fdb = new fouziaDBEntities())
            {

                if (_Tbl.serviceID == 0)
                {
                    try
                    {
                        fdb.Entry<service_tbl>(_Tbl).State = System.Data.Entity.EntityState.Added;
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
                        service_tbl cat = new service_tbl { serviceID = _Tbl.serviceID, serviceName = _Tbl.serviceName };
                        fdb.Entry<service_tbl>(cat).State = System.Data.Entity.EntityState.Modified;
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
            service_tbl obj = servicetblBindingSource.Current as service_tbl;
            using (fdb = new fouziaDBEntities())
            {
                if (obj != null)
                {
                    try
                    {
                        if (fdb.Entry(obj).State == EntityState.Detached)
                            fdb.Set<service_tbl>().Attach(obj);
                        fdb.Entry(obj).State = EntityState.Deleted;
                        servicetblBindingSource.RemoveCurrent();
                        fdb.SaveChanges();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {

                        MessageBox.Show("لا يمكنك حذف هذه المصلحة إلا بعد حذف القضايا التابعة لها");
                    }
                }


            }
            metroPanel.Enabled = false;
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metroPanel.Enabled = true;
        }

        private void txtSearchService_TextChanged(object sender, EventArgs e)
        {
            using (fdb = new fouziaDBEntities())
            {
                if (txtSearchService.Text != "")
                {
                    var result = (from c in fdb.service_tbl.DefaultIfEmpty()
                                  where c.serviceName.Contains(txtSearchService.Text)
                                  select c).ToList();
                    servicetblBindingSource.DataSource = result;

                }

            }
        }
    }
}
