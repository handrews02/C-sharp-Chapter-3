using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIcalculator
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

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            sum = num1 + num2;
            lblResult.Text = "The sum is " + sum;
        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int subtract;
            num1= Convert.ToInt32(txtNumber1.Text);
            num2= Convert.ToInt32(txtNumber2.Text);

            subtract = num1 - num2;
            lblResult2.Text= "The result is " + subtract;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double divide;

            num1= Convert.ToInt32(txtNumber1.Text);
            num2= Convert.ToInt32(txtNumber2.Text);

            divide = num1 / num2;
            lblResult3.Text = "The result is " + divide;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            double multiply;

            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            multiply = num1 * num2;
            lblResult4.Text = "The result is " + multiply;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double modulus;

            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            modulus = num1 % num2;
            lblResult5.Text = "The result is " + modulus;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAnswers_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double sum;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            sum = num1 + num2;
            lblResult.Text = "The sum is " + sum;

            
            double subtract;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            subtract = num1 - num2;
            lblResult2.Text = "The result is " + subtract;

            
            double divide;

            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            divide = num1 / num2;
            lblResult3.Text = "The result is " + divide;

            
            double multiply;

            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            multiply = num1 * num2;
            lblResult4.Text = "The result is " + multiply;

        
            double modulus;

            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            modulus = num1 % num2;
            lblResult5.Text = "The result is " + modulus;
        }
    }
}
