using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class Form1 : Form
    {
        int b, n, d, f;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n=int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + n;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            b=int.Parse(textBox1.Text);
            op = "+";
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = int.Parse(textBox1.Text);
            op = "-";
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            b = int.Parse(textBox1.Text);
            op = "*";
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            b = int.Parse(textBox1.Text);
            op = "/";
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            d=int.Parse(textBox1.Text);
            switch(op)
            {
                case "+":
                    f = b + d;
                    textBox1.Text = "" + f;
                    break;
                case "-":
                    f = b - d;
                    textBox1.Text = "" + f;
                    break;
                case "*":
                    f = b * d;
                    textBox1.Text = "" + f;
                    break;
                case "/":
                    f = b / d;
                    textBox1.Text = "" + f;
                    break;
            }
        }

        string op;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
