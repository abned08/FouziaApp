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
    public partial class frmStatJudgmentOnTheCase : MetroFramework.Forms.MetroForm
    {
        public frmStatJudgmentOnTheCase()
        {
            InitializeComponent();
            label.Text += DateTime.Today.ToString("yyyy/MM/dd");
        }


        fouziaDBEntities fdb;
        private void frmStatJudgmentOnTheCase_Load(object sender, EventArgs e)
        {
            using (fdb = new fouziaDBEntities())
            {
                var result = (from c in fdb.judgmentOnTheCase_tbl
                              join j in fdb.case_tbl on c.JOCID equals j.JOCID into ps
                              from nt in ps.DefaultIfEmpty()
                              group nt by c.JOCName into grp
                              select new { name = grp.Key, cnt = grp.Count(t => t.JOCID != null) }).ToList();
                dgvJOC.DataSource = result;

                int sum1 = 0;
                for (int i = 0; i < dgvJOC.Rows.Count; ++i)
                {
                    sum1 += Convert.ToInt32(dgvJOC.Rows[i].Cells[1].Value);
                }

                txtSum.Text = sum1.ToString();

            }
        }
    }
}
