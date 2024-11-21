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
            var items = new string[] { "A", "B", "C", "D", "F" };

            cmbNMLT.Items.AddRange(items);
            cmbTHNMLT.Items.AddRange(items);
            cmbLTHDT.Items.AddRange(items);
            cmbTHLTHDT.Items.AddRange(items);
            cmbCTDLGT.Items.AddRange(items);
            cmbTHCTDLGT.Items.AddRange(items);
            cmbCSDL.Items.AddRange(items);
            cmbTHCSDL.Items.AddRange(items);
            cmbTCC.Items.AddRange(items);
        }
    }
}
