using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace Buoi10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadKhoaToComboBox(this.cmbKhoa, "Khoa");
        }
        private async Task LoadKhoaToComboBox(ComboBox cmbKhoa, string rootName)
        {
            try
            {
                List<Khoa> danhSachKhoa = await BLL_Khoa.getDSKhoa(rootName);
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
