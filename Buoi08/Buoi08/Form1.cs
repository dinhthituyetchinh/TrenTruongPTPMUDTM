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
namespace Buoi08
{
    public partial class Form1 : Form
    {
        BLL_Khoa dtKhoa = new BLL_Khoa();
        BLL_Lop dtLop = new BLL_Lop();
        BLL_SinhVien dtSinhVien = new BLL_SinhVien();
        BLL_MonHoc dtMH = new BLL_MonHoc();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.cmbKhoa.SelectedValueChanged += cmbKhoa_SelectedValueChanged;
            this.cmbLop.SelectedIndexChanged +=cmbLop_SelectedIndexChanged;
            this.btnDong.Click += btnDong_Click;
            this.btnWord.Click += btnWord_Click;
            this.btnExcel.Click += btnExcel_Click;
        }

        void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();


            if (dataGridViewKhoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất");
                return;
            }

            List<Khoa> pListKhoa = new List<Khoa>();

            // Đổ dữ liệu vào danh sách
            foreach (DataGridViewRow item in dataGridViewKhoa.Rows)
            {
                Khoa i = new Khoa();
                i.MaKhoa = item.Cells[0].Value.ToString();
                i.TenKhoa = item.Cells[1].Value.ToString();
                pListKhoa.Add(i);
            }
            string path = string.Empty;

            excel.ExportKhoa(pListKhoa, ref path, false);
            // Confirm for open file was exported
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }

        }

        void btnWord_Click(object sender, EventArgs e)
        {
            ////Demo bai word mau

            //WordExport w = new WordExport();
            //w.QuyetDinhKhenThuong("10", "10", "2024", "Nguyen Van A", "123456");

            WordExport w = new WordExport();
            SinhVien sv = new SinhVien();
            sv.HoTen = "Nguyen Van A";
            sv.NgaySinh = DateTime.Now;
            sv.MaLop = "1212";
            w.ThongTinSinhVien(sv);
        }

        void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop.SelectedItem != null)
            {
                var maKhoa = cmbKhoa.SelectedValue.ToString();
                var khoaChon = dtKhoa.getDSKhoa().FirstOrDefault(k => k.MaKhoa == maKhoa);

                var maLop = cmbLop.SelectedValue.ToString();
                var selectedLop = dtLop.DSLop(khoaChon).FirstOrDefault(lop => lop.MaLop == maLop);

                if (selectedLop != null)
                {
                    var danhSachSV = dtSinhVien.GetSVTheoLop(selectedLop);
                  
                    dataGridViewSinhVien.DataSource = danhSachSV;

                    if (danhSachSV == null || !danhSachSV.Any())
                    {
                        MessageBox.Show("Không có sinh viên nào cho lớp này.");
                    }
                }
            }
            else
            {
                dataGridViewSinhVien.DataSource = null; 
            }
        }



        void cmbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                var maKhoa = cmbKhoa.SelectedValue.ToString();               
                var khoaChon = dtKhoa.getDSKhoa().FirstOrDefault(k => k.MaKhoa == maKhoa);

                if (khoaChon != null)
                {                  
                    var danhSachLop = dtLop.DSLop(khoaChon);
                    if (danhSachLop != null && danhSachLop.Any())
                    {
                        cmbLop.DataSource = danhSachLop;
                        cmbLop.DisplayMember = "TenLop"; 
                        cmbLop.ValueMember = "MaLop"; 
                    }
                    else
                    {                       
                        cmbLop.DataSource = null; 
                    }
                }
            }
            else
            {
                cmbLop.DataSource = null;
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            this.cmbKhoa.DataSource = dtKhoa.getDSKhoa();
            this.cmbKhoa.DisplayMember = "TenKhoa";
            this.cmbKhoa.ValueMember = "MaKhoa";

            this.cmbMH.DataSource = dtMH.getDSMH();
            this.cmbMH.DisplayMember = "TenMonHoc";
            this.cmbMH.ValueMember = "MaMonHoc";


            this.dataGridViewKhoa.DataSource = dtKhoa.getDSKhoa();
        }
    }
}
