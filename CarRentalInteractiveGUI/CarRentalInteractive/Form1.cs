using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDays_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;

            num1 = Convert.ToInt32(txtDays.Text);
            num2 = Convert.ToInt32(txtMiles.Text);

            double total;

            total = (num1 * 20) + (num2 * 0.25);

            lblTotal.Text = "Your estimated total is $" + total;
        }
    }
}
