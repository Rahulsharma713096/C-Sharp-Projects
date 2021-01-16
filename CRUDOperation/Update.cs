using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOperation
{
    public partial class Update : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-94V18RE;Initial Catalog=rahuldb;Integrated Security=True");
        SqlCommand cmd;
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                cmd = new SqlCommand("update r1 set Name=@name where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
              
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
    }
}
