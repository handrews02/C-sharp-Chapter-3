using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double num3;

            double salary1;
            double salary2;
            double salary3;

            num1 = Convert.ToInt32(txtSalary1.Text);
            num2 = Convert.ToInt32(txtSalary2.Text);
            num3 = Convert.ToInt32(txtSalary3.Text);

            salary1 = (num1 * 0.04) + num1;
            salary2 = (num2 * 0.04) + num2;
            salary3 = (num3 * 0.04) + num3;

            lblTotal1.Text = "Your new salary with a 4% raise is $" + salary1;
            lblTotal2.Text = "Your new salary with a 4% raise is $" + salary2;
            lblTotal3.Text = "Your new salary with a 4% raise is $" + salary3;
        }
    }
}
