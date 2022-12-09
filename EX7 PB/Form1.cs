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

namespace EX7_PB
{
    public partial class PVS_LAB : Form
    {
        public PVS_LAB()
        {
            InitializeComponent();
        }

        private void PVS_LAB_Load(object sender, EventArgs e)
        {

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
            conn.ConnectionString = "Data Soure=HPCSE-16/ADMIN; Initial Catalog=student;Integrated Security=true";
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from stu";
            ada.SelectCommand = comm;
            ada.Fill(ds);
            conn.Close();
            ds.WriteXml("F:/CBT/student.xml");
            MessageBox.Show("xml document generated successfully");
        }
    }
}
