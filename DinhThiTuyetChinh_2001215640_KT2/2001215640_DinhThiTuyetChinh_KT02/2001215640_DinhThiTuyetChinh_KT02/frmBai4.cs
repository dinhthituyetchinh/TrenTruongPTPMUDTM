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
    public partial class frmBai4 : Form
    {
        XuLy dt = new XuLy();
        public frmBai4()
        {
            InitializeComponent();
            this.Load += frmBai4_Load;
            this.btnThem.Click += btnThem_Click;
            this.dataGridViewNCC.CellClick += dataGridViewNCC_CellClick;
            this.btnXoa.Click += btnXoa_Click;
            this.btnSua.Click += btnSua_Click;
        }

        void btnSua_Click(object sender, EventArgs e)
        {

            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = textBoxMaNCC.Text;
            ncc.TenNCC = textBoxTenNCC.Text;
            ncc.DiaChi = textBoxDiaChi.Text;

            bool kq = dt.SuaNCC(ncc);
            if (kq == true)
            {
                frmBai4_Load(sender, e);
                MessageBox.Show("Sửa thành công!");

                textBoxMaNCC.Clear();
                textBoxMaNCC.Focus();
                textBoxTenNCC.Clear();
                textBoxDiaChi.Clear();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = textBoxMaNCC.Text;
            string ma = ncc.MaNCC;

            bool kq = dt.XoaNCC(ma);
            if (kq == true)
            {
                frmBai4_Load(sender, e);

                MessageBox.Show("Xóa thành công!");
              
                textBoxMaNCC.Clear();
                textBoxMaNCC.Focus();
            }
            else
            {
                MessageBox.Show("Không tìm thấy NCC để xóa.");
            }
        }

        void dataGridViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dataGridViewNCC.Rows[e.RowIndex];

                textBoxMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                textBoxTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                textBoxDiaChi.Text = row.Cells["DiaChi"].Value.ToString();    
            }
        }

        void btnThem_Click(object sender, EventArgs e)
        {
            
            NhaCungCap ncc = new NhaCungCap();
                ncc.MaNCC = textBoxMaNCC.Text;
                ncc.TenNCC = textBoxTenNCC.Text;
                ncc.DiaChi = textBoxDiaChi.Text;
            bool kq = dt.ThemNCC(ncc);
            if (kq == true)
            {              

                frmBai4_Load(sender, e);

                MessageBox.Show("Thêm phòng thành công!");
                textBoxMaNCC.Clear();
                textBoxMaNCC.Focus();
                textBoxTenNCC.Clear();
                textBoxDiaChi.Clear();
            }
            else
            {
                MessageBox.Show("Thêm phòng không thành công. Phòng có thể đã tồn tại.");
            }
        }

        void frmBai4_Load(object sender, EventArgs e)
        {
            dataGridViewNCC.DataSource = dt.getPhong();
        }
    }
}
