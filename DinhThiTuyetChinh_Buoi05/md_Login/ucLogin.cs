using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;
using System.Data.Sql;
using System.Data.SqlClient;

namespace md_Login
{
    public partial class ucLogin : UserControl
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public event EventHandler GetChangeKQ;
        public ucLogin()
        {
            InitializeComponent();
            this.btnDangNhap.Click += btnDangNhap_Click;
            this.btnHuy.Click += btnHuy_Click;
        }

        void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string pConfig;
        private bool _tt;

        public bool Tt
        {
            get { return _tt; }
            set { _tt = value; }
        }
        public string PConfig
        {
            get { return pConfig; }
            set { pConfig = value; }
        }

        void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lblTenDangNhap.Text.ToLower());
                this.txtTenDangNhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống" + lblMatKhau.Text.ToLower());
                this.txtMatKhau.Focus();
                return;
            }
            CauHinh.PConfig = PConfig;
            if (CauHinh.Check_Config() == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (CauHinh.Check_Config() == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }
            if (CauHinh.Check_Config() == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }

        public void ProcessLogin()
        {
            ThuVien.QL_NguoiDung.LoginResult result;
            result = CauHinh.Check_User(txtTenDangNhap.Text, txtMatKhau.Text);
            // Wrong username or pass
            if (result == ThuVien.QL_NguoiDung.LoginResult.Invalid)
            {
                Tt = false;
                MessageBox.Show("Sai " + lblTenDangNhap.Text + " Hoặc " + lblMatKhau.Text);
                return;
            }
            // Account had been disabled
            else if (result == ThuVien.QL_NguoiDung.LoginResult.Disabled)
            {
                Tt = false;
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            Tt = true;
            GetChangeKQ.Invoke(this, EventArgs.Empty);

        }


        public void ProcessConfig()
        {
            Tt = true;
            GetChangeKQ.Invoke(this, EventArgs.Empty);
        }
    }
}
