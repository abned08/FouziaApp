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
    public partial class frmAddRecord : MetroFramework.Forms.MetroForm
    {
        public frmAddRecord()
        {
            InitializeComponent();
        }


        fouziaDBEntities fdb;
        private void frmAddRecord_Load(object sender, EventArgs e)
        {
            using (fdb = new fouziaDBEntities())
            {
                recordtblBindingSource.DataSource = fdb.record_tbl.ToList();
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            recordtblBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = true;
            recordtblBindingSource.Add(new record_tbl());
            recordtblBindingSource.MoveLast();
        }

        private void btnAddToContext_Click(object sender, EventArgs e)
        {
            record_tbl _Tbl = recordtblBindingSource.Current as record_tbl;

            using (fdb = new fouziaDBEntities())
            {

                if (_Tbl.recordID == 0)
                {
                    try
                    {
                        fdb.Entry<record_tbl>(_Tbl).State = System.Data.Entity.EntityState.Added;
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
                        record_tbl per = new record_tbl { recordID = _Tbl.recordID, recordNum = _Tbl.recordNum };
                        fdb.Entry<record_tbl>(per).State = System.Data.Entity.EntityState.Modified;
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
            record_tbl obj = recordtblBindingSource.Current as record_tbl;
            using (fdb = new fouziaDBEntities())
            {
                if (obj != null)
                {
                    try
                    {
                        if (fdb.Entry(obj).State == EntityState.Detached)
                            fdb.Set<record_tbl>().Attach(obj);
                        fdb.Entry(obj).State = EntityState.Deleted;
                        recordtblBindingSource.RemoveCurrent();

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

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metroPanel.Enabled = true;
        }
    }
}
