using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKilometers_Click(object sender, EventArgs e)
        {
            double num1;
            double kilometers = 1.6;
            double conversion;
            num1 = Convert.ToInt32(txtMiles.Text);

            conversion = num1 * 1.6;
            lblResult.Text = conversion + " Kilometers";
        }
    }
}
