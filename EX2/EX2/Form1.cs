using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
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

        private void CHECK_Click(object sender, EventArgs e)
        {
            
            {
                if (textBox1.Text == "a" || textBox1.Text == "e" || textBox1.Text == "i" || textBox1.Text == "o" || textBox1.Text == "u" || textBox1.Text == "A" || textBox1.Text == "E" || textBox1.Text == "I" || textBox1.Text == "O" || textBox1.Text == "U")
                    textBox2.Text = "   VOWEL";
                else
                    textBox2.Text = "NOT VOWEL";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
