using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public SqlConnection conn;
		public SqlCommand comm;
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			conn = new SqlConnection();
			comm = new SqlCommand();
			conn.ConnectionString = "Data Source=HPCSE-15\\SQLEXPRESS01;Initial Catalog=student;Integrated Security=true";
			conn.Open();
			comm.Connection = conn;
			if (PVS_BOX1.Text == "" || PVS_BOX2.Text == "" || PVS_BOX3.Text == "")
				MessageBox.Show("Please fill all the details");
			else
			{
				comm.CommandText = "insert into stu values('"+PVS_BOX1.Text+"','"+PVS_BOX2.Text+"','"+PVS_BOX3.Text+"')";
				comm.ExecuteNonQuery();
				MessageBox.Show("1 record is stored successfully");
			}
			PVS_BOX1.Clear();
			PVS_BOX2.Clear();
			PVS_BOX3.Clear();

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


