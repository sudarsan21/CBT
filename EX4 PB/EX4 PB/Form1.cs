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

namespace EX4_PB
{
    public partial class Form1 : Form
    {
        public SqlCommand com;
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            com = new SqlCommand();
            da = new SqlDataAdapter();
            ds = new DataSet();
            con.ConnectionString = "Data Source=HPCSE-16\\SQLEXPRESS;Initial Catalog=student;Integrated Security=true";
            con.Open();
            com.Connection = con;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            com.CommandText = "update stu  set  sname='" + dataGridView1.CurrentRow.Cells[1].Value + "',dept='"+ dataGridView1.CurrentRow.Cells[3].Value + "'where regno='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
            com.ExecuteNonQuery();
            MessageBox.Show("One record updated...");
            SqlDataAdapter da1 = new SqlDataAdapter("select *from stu", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "stu");
            dataGridView1.DataSource = ds1.Tables["stu"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            com.CommandText="insert into stu values('"+textBox1.Text+"','"+textBox2.Text+"','" + textBox3.Text+"','" + textBox4.Text+"')";
            com.ExecuteNonQuery();
            MessageBox.Show("One record Inserted");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            com.CommandText = "select *from stu";
            da.SelectCommand = com;
            da.Fill(ds, "stu");
            dataGridView1.DataSource = ds.Tables["stu"];
        }
    }
}
