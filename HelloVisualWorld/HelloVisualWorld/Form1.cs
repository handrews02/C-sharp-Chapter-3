﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloVisualWorld
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

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            lblHello.Visible = true;
            lblHello.Text = "Hello visual World";
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Goodbye";
        }
    }
}
