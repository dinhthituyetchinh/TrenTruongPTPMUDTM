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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
           ucLogin2.PConfig = Properties.Settings.Default.Conn;
           ucLogin2.GetChangeKQ += ucLogin2_GetChangeKQ;
        }

        void ucLogin2_GetChangeKQ(object sender, EventArgs e)
        {
            if(ucLogin2.Tt == true)
            {
                if (Program.mainForm == null || Program.mainForm.IsDisposed)
                {
                    Program.mainForm = new frmMain();
                }
                this.Visible = false;
                Program.mainForm.Show();
            }
        }
    }
}
