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
    public partial class frmStatAppeal : MetroFramework.Forms.MetroForm
    {
        public frmStatAppeal()
        {
            InitializeComponent();
            label.Text += DateTime.Today.ToString("yyyy/MM/dd");
        }

        fouziaDBEntities fdb;
        private void frmStatAppeal_Load(object sender, EventArgs e)
        {
            using (fdb = new fouziaDBEntities())
            {
                List<Tuple<String, string>> mylist = new List<Tuple<String, string>>();

                int result = fdb.appealCouncilOfState_tbl.Select(c => c.appealID).Count();

                int result2 = fdb.appealSupremeCourt_tbl.Select(c => c.appealID).Count();

                mylist.Add(new Tuple<string, string>("عدد القضايا التي تم الاستئناف فيها أمام مجلس الدولة ", result.ToString()));
                mylist.Add(new Tuple<string, string>("عدد القضايا التي تم الاستئناف فيها أمام المحكمة العليا ", result2.ToString()));

                dgvAppeal.DataSource = mylist;

                int sum1 = 0;
                for (int i = 0; i < dgvAppeal.Rows.Count; ++i)
                {
                    sum1 += Convert.ToInt32(dgvAppeal.Rows[i].Cells[1].Value);
                }

                txtSum.Text = sum1.ToString();

            }
        }
    }
}
