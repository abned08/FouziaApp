using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FouziaApp
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        static frmMain _instance;
        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mtPanel; }
            set { mtPanel = value; }
        }
       
        public frmMain()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            String FilesDir = Environment.CurrentDirectory+"/filesPDF";
            if (!Directory.Exists(FilesDir))
                Directory.CreateDirectory(FilesDir);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            _instance = this;

        }

        private void mtdisputes_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucDisputes"))
            {
            
                ucDisputes uc = new ucDisputes();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            frmMain.Instance.MetroContainer.Controls["ucDisputes"].BringToFront();

        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void mtBeforeDisputes_Click(object sender, EventArgs e)
        {
            
        }
    }
}
