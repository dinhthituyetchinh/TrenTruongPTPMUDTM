using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using ThuVien;

namespace mdDB
{
    public partial class ucDB: UserControl
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        private string chuoi_CH;

        public string Chuoi_CH
        {
            get { return chuoi_CH; }
            set { chuoi_CH = value; }
        }
        public ucDB()
        {
            InitializeComponent();
            this.cboServer.DropDown += cboServer_DropDown;
            this.cboDatabase.DropDown += cboDatabase_DropDown;
            this.btnLuu.Click += btnLuu_Click;
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            Chuoi_CH = cboServer.Text + "," + txtUsername.Text + "," + txtPassword.Text + "," + cboDatabase.Text;
            Application.Exit();
        }

       private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            cboDatabase.DataSource = CauHinh.GetDBName(cboServer.Text, txtUsername.Text, txtPassword.Text);
            cboDatabase.DisplayMember = "name";
        }

       private void cboServer_DropDown(object sender, EventArgs e)
        {
            DataTable dt = CauHinh.GetServerName();
            cboServer.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    cboServer.Items.Add(row[col]);
                }
            }
        }

       
    }
}
