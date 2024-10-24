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
using DAL_FB;
namespace FB
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        public async void LoadKhoa()
        {
            // Load du lieu
            List<Khoa> dskhoa = await DAL_Khoa_FB.GetThongTinKhoa("Khoa");

            comboBox1.DataSource = dskhoa;
            comboBox1.DisplayMember = "TenKhoa";
        }
        void Form1_Load(object sender, EventArgs e)
        {
            LoadKhoa();
        }
    }
}
