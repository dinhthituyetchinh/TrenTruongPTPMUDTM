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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
            this.btnLoaiSanPham.Click += btnLoaiSanPham_Click;
            this.btnPhieuNhap.Click += btnPhieuNhap_Click;
        }

        void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frm = new frmPhieuNhap();
            frm.Show();
            this.Close();
        }

        void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frm = new frmLoaiSanPham();
            frm.Show();
            this.Close();
        }

   
    }
}
