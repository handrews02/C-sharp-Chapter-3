using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            double grossPay;
            double hourlyPay;
            double fdrlTax;
            double stateTax;
            double netPay;
            double hoursWorked;

            hoursWorked = Convert.ToDouble(txtHours.Text);
            hourlyPay = Convert.ToDouble(txtHours.Text);
            grossPay = hoursWorked * hourlyPay;
            fdrlTax = grossPay * 0.15;
            stateTax = grossPay * 0.05;
            netPay = grossPay - fdrlTax - stateTax;

            lblGrossPayOut.Text = "It is " + grossPay;
            lblFedTaxOut.Text = "It is " + fdrlTax;
            lblStateTaxOut.Text = "It is " + stateTax;
            lblNetPayOut.Text = "It is " + netPay;
        }
    }
}
