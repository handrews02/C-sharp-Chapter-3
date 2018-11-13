using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;

            num1 = Convert.ToInt32(txtGuests1.Text);
            num2 = Convert.ToInt32(txtGuests2.Text);

            double revenue;
            revenue = num2 * 25;
            lblRevenue.Text = "This years projected revenue is $" + revenue;

            if(num1 > num2)
            {
                lblMoreOrLess.Text = "This year there are less guests participating";
            }
            else if (num1< num2)
            {
                lblMoreOrLess.Text = "This year there are more guests participating";
            }

            
        }
    }
}
