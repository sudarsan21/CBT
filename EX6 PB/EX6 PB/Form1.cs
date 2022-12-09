using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX6_PB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = "B:\\CBT/EX6 PB/student.xml";
            dataSet1.ReadXml(filepath);
            dataGridView1.DataSource = dataSet1;
            dataGridView1.DataMember = "stu";
        }
    }
}
