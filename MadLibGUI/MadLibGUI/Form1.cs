using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibGUI
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

        private void lblNoun_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String color;
            String est;
            String bodyPart;
            String animal;
            String noun;
            String pluralNoun;
            int num1;
            int num2;
            int num3;

            color = (txtColor.Text);
            est = (txtWordEST.Text);
            bodyPart = (txtBodyPart.Text);
            animal = (txtAnimal.Text);
            noun = (txtNoun.Text);
            pluralNoun = (txtPluralNoun.Text);
            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);
            num3 = num1 - num2;

            lblStory.Text = "The " + color + " dragon is the " + est + " dragon of all. It has " + num3 + " " + bodyPart + " and a " + animal + " shaped like a " + noun + ". It loves to eat " + pluralNoun + ", although it will feast on nearly anything."; 



        }
    }
}
