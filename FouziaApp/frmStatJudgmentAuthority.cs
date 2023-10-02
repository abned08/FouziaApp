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
    public partial class frmStatJudgmentAuthority : MetroFramework.Forms.MetroForm
    {
        public frmStatJudgmentAuthority()
        {
            InitializeComponent();
            label.Text += DateTime.Today.ToString("yyyy/MM/dd");
        }

        fouziaDBEntities fdb;
        private void frmStatJudgmentAuthority_Load(object sender, EventArgs e)
        {
            using (fdb=new fouziaDBEntities())
            {
                var result = (from c in fdb.receiptOfCase_tbl
                              join j in fdb.case_tbl on c.rcID equals j.rcID into ps
                              from nt in ps.DefaultIfEmpty()
                              group nt by c.rcJudicialAuthority into grp
                              select new { name ="عدد القضايا المرفوعة أمام "+ grp.Key, cnt = grp.Count(t=>t.rcID !=null) }).ToList();
                dgvJudgmentA.DataSource = result;

                int sum1 = 0;
                for (int i = 0; i < dgvJudgmentA.Rows.Count; ++i)
                {
                    sum1 += Convert.ToInt32(dgvJudgmentA.Rows[i].Cells[1].Value);
                }

                int result2 = fdb.case_tbl.Where(c => c.finished == true).Select(c => c.finished).Count();
                List<Tuple<String, string>> mylist = new List<Tuple<String, string>>();
                mylist.Add(new Tuple<string, string>("عدد القضايا المحالة إلى الحفظ", result2.ToString()));

                dgvJudgmentAFinished.DataSource = mylist;

                int sumT = sum1 + result2;
                txtSum.Text = sumT.ToString();

            }

        }
    }
}
