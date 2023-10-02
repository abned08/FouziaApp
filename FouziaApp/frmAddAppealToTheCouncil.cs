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
    public partial class frmAddAppealToTheCouncil : MetroFramework.Forms.MetroForm
    {
        public frmAddAppealToTheCouncil(appealCouncilOfState_tbl appeal_)
        {
            InitializeComponent();
            appealCouncilOfStatetblBindingSource.DataSource = appeal_;
        }


        public appealCouncilOfState_tbl councilInfo { get { return appealCouncilOfStatetblBindingSource.Current as appealCouncilOfState_tbl; } }

        private void frmAddAppealToTheCouncil_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            appealCouncilOfStatetblBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
