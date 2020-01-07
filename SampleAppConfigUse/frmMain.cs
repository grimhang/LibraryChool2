using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppConfigTool;

namespace SampleAppConfigUse
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnString_Click(object sender, EventArgs e)
        {
            txtConnString.Text = AppConfig.GetConnectionStringByName("dwConn");
        }

        private void btnConfigInfo_Click(object sender, EventArgs e)
        {
            txtConfigInfo.Text = AppConfig.GetAppConfig("excelPath2");
        }
    }
}
