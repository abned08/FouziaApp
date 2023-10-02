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
    public partial class frmAddPerson : MetroFramework.Forms.MetroForm
    {
        public frmAddPerson()
        {
            InitializeComponent();
            //personstblBindingSource.DataSource = person;

        }

        //public persons_tbl personInfo { get { return personstblBindingSource.Current as persons_tbl ; } }

        fouziaDBEntities fdb;
        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            cbCaseSubj.DisplayMember = "csAdress";
            cbCaseSubj.ValueMember = "csID";
            cbPTC.DisplayMember = "PTCName";
            cbPTC.ValueMember = "PTCID";

            using ( fdb = new fouziaDBEntities())
            {
                cbCaseSubj.DataSource = fdb.caseSubject_tbl.ToList();
                cbPTC.DataSource = fdb.partiesToTheConflict_tbl.ToList();
                caseSubjecttblBindingSource.DataSource = fdb.caseSubject_tbl.ToList();
                partiesToTheConflicttblBindingSource.DataSource = fdb.partiesToTheConflict_tbl.ToList();
                personstblBindingSource.DataSource = fdb.persons_tbl.ToList();
            }

            //if (personInfo.csID != null && personInfo.PTCID != null)
            //{
            //    cbCaseSubj.SelectedValue = personInfo.csID;
            //    cbPTC.SelectedValue = personInfo.PTCID;

            //}

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPerson_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            //{
            //    object value = dgvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //    if (!((DataGridViewComboBoxColumn)dgvPerson.Columns[e.ColumnIndex]).Items.Contains(value))
            //    {
            //        ((DataGridViewComboBoxColumn)dgvPerson.Columns[e.ColumnIndex]).Items.Add(value);
            //        e.ThrowException = false;
            //    }
            //}

        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = true;
            personstblBindingSource.Add(new persons_tbl());
            personstblBindingSource.MoveLast();


        }

        private void btnAddToContext_Click(object sender, EventArgs e)
        {
            persons_tbl _Tbl = personstblBindingSource.Current as persons_tbl;

            using (fdb=new fouziaDBEntities())
            {

                if(_Tbl.personID==0)
                {
                    try
                    {
                        fdb.Entry<persons_tbl>(_Tbl).State = System.Data.Entity.EntityState.Added;
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
                        persons_tbl per = new persons_tbl { personID = _Tbl.personID,personName=_Tbl.personName, csID = _Tbl.csID, PTCID = _Tbl.PTCID };
                        fdb.Entry<persons_tbl>(per).State = System.Data.Entity.EntityState.Modified;
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
            persons_tbl obj=personstblBindingSource.Current as persons_tbl;
            using (fdb= new fouziaDBEntities())
            {
                if (obj != null)
                {
                    try
                    {
                        if (fdb.Entry(obj).State == EntityState.Detached)
                            fdb.Set<persons_tbl>().Attach(obj);
                        fdb.Entry(obj).State = EntityState.Deleted;
                        personstblBindingSource.RemoveCurrent();

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

        private void txtSearchPerson_TextChanged(object sender, EventArgs e)
        {
            using(fdb=new fouziaDBEntities())
            {
                if (txtSearchPerson.Text != "")
                {
                    var result = (from p in fdb.persons_tbl.DefaultIfEmpty()
                                  where p.personName.Contains(txtSearchPerson.Text)
                                  join s in fdb.caseSubject_tbl on p.csID equals s.csID
                                  join t in fdb.partiesToTheConflict_tbl on p.PTCID equals t.PTCID
                                  select p).ToList();
                    personstblBindingSource.DataSource = result;

                }

            }
        }
    }
}
