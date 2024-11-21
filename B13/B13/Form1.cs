using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace B13
{
    public partial class Form1 : Form
    {
        XuLy dt = new XuLy();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = dt.loadDL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
