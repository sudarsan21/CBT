using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;


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
            SqlConnection conn;
            SqlCommand comm;
            SqlDataAdapter ada;
            DataSet ds;
            conn = new SqlConnection();
            comm = new SqlCommand();
            ada = new SqlDataAdapter();
            ds = new DataSet();
            conn.ConnectionString = "Data Source=HPCSE-16\\SQLEXPRESS;Initial Catalog = student;Integrated Security=true" ;
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from stud";
            ada.SelectCommand = comm;
            ada.Fill(ds);
            conn.Close();
            ds.WriteXml("B:\\CBT/student.xml");
            MessageBox.Show("Xml document generated successfully");


        }
    }
}
