using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhThiTuyetChinh_Buoi05
{
    public partial class frmConfigDB : Form
    {
        public frmConfigDB()
        {
            InitializeComponent();
        }

        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            DinhThiTuyetChinh_Buoi05.Properties.Settings.Default.LTWNCConn = "Data Source=" + pServer + ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + "";
            DinhThiTuyetChinh_Buoi05.Properties.Settings.Default.Save();
        }
    }
}
