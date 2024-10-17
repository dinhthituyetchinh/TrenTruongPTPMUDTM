using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace FireBase
{
    public partial class frmQuanLyDiem : Form
    {
        

        public frmQuanLyDiem()
        {
            InitializeComponent();
           
            this.Load += frmQuanLyDiem_Load;
        }

        private async void frmQuanLyDiem_Load(object sender, EventArgs e)
        {
            await LoadKhoaToComboBox(this.cmbKhoa, "Khoa");
        }


        private async Task LoadKhoaToComboBox(ComboBox cmbKhoa, string rootName)
        {
            try
            {
                List<Khoa> danhSachKhoa = await FireBase.GetThongTinKhoa(rootName);

                if (danhSachKhoa != null && danhSachKhoa.Count > 0)
                {
                    cmbKhoa.DataSource = danhSachKhoa;
                    cmbKhoa.DisplayMember = "TenKhoa"; 
                    cmbKhoa.ValueMember = "MaKhoa"; 
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu khoa nào được tìm thấy.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách khoa: " + ex.Message);
            }
        }


    }
}
