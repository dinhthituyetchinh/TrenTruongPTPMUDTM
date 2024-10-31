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
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void loaiSanPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loaiSanPhamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLySanPham);

        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySanPham.LoaiSanPham' table. You can move, or remove it, as needed.
            this.loaiSanPhamTableAdapter.Fill(this.quanLySanPham.LoaiSanPham);

        }
    }
}
