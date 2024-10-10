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
        }
    }
}
