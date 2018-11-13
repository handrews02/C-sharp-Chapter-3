using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int num3;
            int num4;
            int num5;

            num1 = Convert.ToInt32(txtEggs1.Text);
            num2 = Convert.ToInt32(txtEggs2.Text);
            num3 = Convert.ToInt32(txtEggs3.Text);
            num4 = Convert.ToInt32(txtEggs4.Text);
            num5 = Convert.ToInt32(txtEggs5.Text);

            int eggTotal;
            int dozen;
            int single;
            eggTotal = num1 + num2 + num3 + num4 + num5;
            dozen = eggTotal / 12;
            single = dozen % 12;

            lblTotal.Text = eggTotal + " eggs is " + dozen + " dozen with " + single + " left over";


        }
    }
}
