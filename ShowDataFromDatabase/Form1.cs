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

namespace ShowDataFromDatabase
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-94V18RE;Initial Catalog=rahuldb;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(textBox1.Text);
                con.Open();
                SqlDataAdapter sda;
                if (i != 0)
                {

                    SqlCommand cmd = new SqlCommand("select * from r1 where id=" + textBox1.Text, con);
                    sda = new SqlDataAdapter(cmd);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select * from r1 ", con);
                    sda = new SqlDataAdapter(cmd);

                }
                DataTable dt = new DataTable();
                sda.Fill(dt);
                textBox1.Text = "";
                Show s1 = new Show(dt);
                s1.Show();
                this.Hide();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.StackTrace);


            }




            MessageBox.Show("Done");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                con.Open();
                SqlDataAdapter sda;
               
                    SqlCommand cmd = new SqlCommand("select * from r1 ", con);
                sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                textBox1.Text = "";
                Show s1 = new Show(dt);
                s1.Show();
                this.Hide();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.StackTrace);


            }




            MessageBox.Show("Done");
            con.Close();
        }
    }
}
