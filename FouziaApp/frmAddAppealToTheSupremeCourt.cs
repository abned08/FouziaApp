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
    public partial class frmAddAppealToTheSupremeCourt : MetroFramework.Forms.MetroForm
    {
        public frmAddAppealToTheSupremeCourt(appealSupremeCourt_tbl appeal_)
        {
            InitializeComponent();
            appealSupremeCourttblBindingSource.DataSource = appeal_;
        }


        public appealSupremeCourt_tbl supremeInfo { get { return appealSupremeCourttblBindingSource.Current as appealSupremeCourt_tbl; } }

        private void btnSave_Click(object sender, EventArgs e)
        {
            appealSupremeCourttblBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
