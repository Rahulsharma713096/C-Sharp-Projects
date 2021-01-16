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

    public partial class InsertForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-94V18RE;Initial Catalog=rahuldb;Integrated Security=True");
        SqlCommand cmd;
       
        //ID variable used in Updating and Deleting Record  
 
        public InsertForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                cmd = new SqlCommand("insert into r1(id,name) values(@id,@name)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
              
        
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
    }
}
