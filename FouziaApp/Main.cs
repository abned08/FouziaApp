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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        static Main _instance;
        public static Main Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Main();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MatroContainer
        {
            get { return mtPanel; }
            set { mtPanel = value; }
        }
        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return mtBack; }
            set { mtBack = value; }
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mtBack.Visible = false;
            _instance = this;
            
        }

        private void mtdisputes_Click(object sender, EventArgs e)
        {
            
            ucDisputes uc = new ucDisputes();
            uc.Dock = DockStyle.Fill;
            mtPanel.Controls.Add(uc);
            mtBack.Visible = true;
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            mtPanel.Controls.Clear();
            mtBack.Visible = false;
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
