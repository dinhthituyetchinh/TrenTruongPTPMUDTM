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

        private void btnGoiY_Click(object sender, EventArgs e)
        {
            // Retrieve selected values from ComboBoxes with null checks (for .NET Framework 4.5 compatibility)
            string nmlt = cmbNMLT.SelectedItem != null ? cmbNMLT.SelectedItem.ToString() : string.Empty;
            string thnnlt = cmbTHNMLT.SelectedItem != null ? cmbTHNMLT.SelectedItem.ToString() : string.Empty;
            string lthdt = cmbLTHDT.SelectedItem != null ? cmbLTHDT.SelectedItem.ToString() : string.Empty;
            string thlthdt = cmbTHLTHDT.SelectedItem != null ? cmbTHLTHDT.SelectedItem.ToString() : string.Empty;
            string ctdlgt = cmbCTDLGT.SelectedItem != null ? cmbCTDLGT.SelectedItem.ToString() : string.Empty;
            string thctdlgt = cmbTHCTDLGT.SelectedItem != null ? cmbTHCTDLGT.SelectedItem.ToString() : string.Empty;
            string csdl = cmbCSDL.SelectedItem != null ? cmbCSDL.SelectedItem.ToString() : string.Empty;
            string thcsdl = cmbTHCSDL.SelectedItem != null ? cmbTHCSDL.SelectedItem.ToString() : string.Empty;
            string tcc = cmbTCC.SelectedItem != null ? cmbTCC.SelectedItem.ToString() : string.Empty;


            // Ensure that all ComboBoxes have a valid selected value
            if (string.IsNullOrEmpty(nmlt) || string.IsNullOrEmpty(thnnlt) || string.IsNullOrEmpty(lthdt) ||
                string.IsNullOrEmpty(thlthdt) || string.IsNullOrEmpty(ctdlgt) || string.IsNullOrEmpty(thctdlgt) ||
                string.IsNullOrEmpty(csdl) || string.IsNullOrEmpty(thcsdl) || string.IsNullOrEmpty(tcc))
            {
                MessageBox.Show("Please select a value for all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the 'thuatToan' method from XuLy class
            double result = dt.thuatToan(nmlt, thnnlt, lthdt, thlthdt, ctdlgt, thctdlgt, csdl, thcsdl, tcc);

            // Show the result (you can display this in a label or a message box)
           MessageBox.Show("The calculated result is: " + result.ToString(), "Algorithm Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
