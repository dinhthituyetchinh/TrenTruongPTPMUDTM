using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001215640_DinhThiTuyetChinh_KT02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.btnBai3.Click += btnBai3_Click;
            this.btnBai4.Click += btnBai4_Click;
            this.btnBai5.Click += btnBai5_Click;
        }

        void btnBai5_Click(object sender, EventArgs e)
        {
            frmBai5 frm = new frmBai5();
            frm.Show();
        }

        void btnBai4_Click(object sender, EventArgs e)
        {
            frmBai4 frm = new frmBai4();
            frm.Show();
        }

        void btnBai3_Click(object sender, EventArgs e)
        {
            frmBai3 frm = new frmBai3();
            frm.Show();
        }
    }
}
