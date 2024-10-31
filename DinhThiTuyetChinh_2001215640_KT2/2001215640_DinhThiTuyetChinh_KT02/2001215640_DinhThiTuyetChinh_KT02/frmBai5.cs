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
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
            this.btnDong.Click += btnDong_Click;
            this.Load += frmBai5_Load;
        }

        void frmBai5_Load(object sender, EventArgs e)
        {
            DisableControls();
        }

        private void DisableControls()
        {
            
            textBoxMaSP.Enabled = false;
            textBoxDG.Enabled = false;
            textBoxSL.Enabled = false;
            textBoxTenSP.Enabled = false;
            comboBoxLSP.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void btnDong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn đóng chương trình");
        }
    }
}
