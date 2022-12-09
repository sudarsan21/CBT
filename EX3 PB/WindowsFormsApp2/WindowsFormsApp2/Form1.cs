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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public SqlConnection con;
        public SqlCommand com;
        public SqlDataReader rd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            com = new SqlCommand();
            con.ConnectionString = "Data source=PVSHOME\\SQLEXPRESS;Initial Catalog=student;Integrated Security=true";
            con.Open();
            com.Connection = con;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Visible = false;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            comboBox1.Visible = true;
            com.CommandText = "select * from stu";
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd.GetString(0));
            }
            rd.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            com.CommandText = "select * from stu where regno='" + comboBox1.SelectedItem + "'";
            rd = com.ExecuteReader();
            if (rd.Read())
            {
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetString(2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("please fill all the details");
            else
            {
                com.CommandText = "insert('"+textBox1.Text+'","'+textBox2.Text+'","'+textBox3.Text+"')";
                com.ExecuteNonQuery();
                MessageBox.Show("record inserted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            com.CommandText = "delete from stu where regno='"+comboBox1.SelectedItem+"'";
                rd = com.ExecuteReader();
            comboBox1.Items.Remove(comboBox1.SelectedText);
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("Record Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            com.CommandText = "update stu set sname='"+textBox2.Text+"',dept='"+textBox3.Text+"'whereregno'"+comboBox1.SelectedItem+"'";
                com.ExecuteNonQuery();
            MessageBox.Show("Record Updated");

        }
    }
}

