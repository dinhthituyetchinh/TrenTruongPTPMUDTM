using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B12
{
    public partial class Form1 : Form
    {
        private List<SinhVien> sinhViens;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView.AutoGenerateColumns = true;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
     
            
        }

        private void LoadData()
        {
             sinhViens = new List<SinhVien>
            {
                new SinhVien
                {
                    MaSV = "2001130172",
                    HoTen = "Đặng Quang Đông",
                    Lop = "04DHTH1",
                    NguyenVong = new NguyenVong
                    {
                        NguyenVong1 = 3,
                        NguyenVong2 = 4,
                        NguyenVong3 = 5
                    }
                },
                new SinhVien
                {
                    MaSV = "2001230434",
                    HoTen = "Đặng Quang Anh",
                    Lop = "04DHTH2",
                    NguyenVong = new NguyenVong
                    {
                        NguyenVong1 = 5,
                        NguyenVong2 = 6,
                        NguyenVong3 = 7
                    }
                },
                new SinhVien
                {
                    MaSV = "2001130234",
                    HoTen = "Nguyễn Thế Sơn",
                    Lop = "04DHTH1",
                    NguyenVong = new NguyenVong
                    {
                        NguyenVong1 = 3,
                        NguyenVong2 = 5,
                        NguyenVong3 = 4
                    }
                },
                new SinhVien
                {
                    MaSV = "3002110001",
                    HoTen = "Trần Quốc Toản",
                    Lop = "04DHTH3",
                    NguyenVong = new NguyenVong
                    {
                        NguyenVong1 = 6,
                        NguyenVong2 = 4,
                        NguyenVong3 = 7
                    }
                },
                new SinhVien
                {
                    MaSV = "2001130174",
                    HoTen = "Phạm Thu Hiền",
                    Lop = "04DHTH2",
                    NguyenVong = new NguyenVong
                    {
                        NguyenVong1 = 4,
                        NguyenVong2 = 5,
                        NguyenVong3 = 6
                    }
                }
            };

           
            dataGridView.DataSource = sinhViens;

                
            dataGridView.Columns["NguyenVong"].Visible = false;

            
            dataGridView.Columns["NguyenVong1"].HeaderText = "Nguyện Vọng 1";
            dataGridView.Columns["NguyenVong2"].HeaderText = "Nguyện Vọng 2";
            dataGridView.Columns["NguyenVong3"].HeaderText = "Nguyện Vọng 3";


        }

        private void btnXepPhongNgauNhien_Click(object sender, EventArgs e)
        {
            int numberOfRooms = int.Parse(textBoxSoPhong.Text);
                // Chuyển đổi danh sách sinh viên thành mảng double
            double[][] observations = sinhViens.Select(sv => new double[]
            {
                sv.NguyenVong.NguyenVong1,
                sv.NguyenVong.NguyenVong2,
                sv.NguyenVong.NguyenVong3
            }).ToArray();

            // Gọi hàm K-Means
            ThuatToan tt = new ThuatToan();
            int[] labels = tt.demoTT(observations, numberOfRooms);

            // Khởi tạo danh sách phòng
            List<Phong> phongList = new List<Phong>();
            for (int i = 1; i <= numberOfRooms; i++)
            {
                phongList.Add(new Phong { MaPhong = i, TenPhong = "Phòng " + i });
            }

            // Gán phòng cho sinh viên dựa trên nhãn
            for (int i = 1; i < sinhViens.Count; i++)
            {
                int roomLabel = labels[i]; // Tạo biến để lưu nhãn
                sinhViens[i].Phong = roomLabel; // Gán phòng cho sinh viên
            }


            dataGridViewXepPhong.DataSource = null; // Xóa dữ liệu cũ
            dataGridViewXepPhong.DataSource = sinhViens; // Cập nhật lại danh sách sinh viên với phòng
    }
    }
    
}
