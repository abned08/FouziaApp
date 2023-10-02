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
    public partial class frmStatCatSub : MetroFramework.Forms.MetroForm
    {
        public frmStatCatSub()
        {
            InitializeComponent();
            label.Text += DateTime.Today.ToString("yyyy/MM/dd");
        }


        fouziaDBEntities fdb;
        private void frmStatCatSub_Load(object sender, EventArgs e)
        {
            using (fdb=new fouziaDBEntities())
            {
                var result = (from c in fdb.catSub_tbl
                              join j in fdb.caseSubject_tbl on c.catSubID equals j.catSubID into ps
                              from nt in ps.DefaultIfEmpty()
                              group nt by c.catSubName into grp
                              select new { name = "عدد القضايا المرفوعة فيما يخص " + grp.Key, cnt = grp.Count(t => t.catSubID != null) }).ToList();
                dgvCatSub.DataSource = result;

                int sum1 = 0;
                for (int i = 0; i < dgvCatSub.Rows.Count; ++i)
                {
                    sum1 += Convert.ToInt32(dgvCatSub.Rows[i].Cells[1].Value);
                }

                txtSum.Text = sum1.ToString();

            }
        }
    }
}
