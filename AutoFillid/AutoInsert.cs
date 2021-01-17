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

namespace AutoFillid
{
    public partial class AutoInsert : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-94V18RE;Initial Catalog=rahuldb;Integrated Security=True");
        SqlCommand cmd;
        private SqlDataReader dr;

        public AutoInsert()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            /*To auti fill there are twi ways:=
            1.Create auto_increment or IDENTITY Colunm.
            2.write code to get max value of id.
             In fillowing are 2nd way
             */
            cmd = new  SqlCommand("Select Max(id)+1 from r1", con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox1.Text = dr[0].ToString();
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "1";
                    }
                }
            }
            else
            {
                textBox1.Text = "1";
                return;
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowData sd = new ShowData(con);
            sd.Show();
            this.Hide();
        }
    }
}
