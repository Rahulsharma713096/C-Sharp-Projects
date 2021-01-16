using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDOperation
{
    public partial class Show1 : Form
    {
        private object dataGridView1;

        public Show1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-94V18RE;Initial Catalog=rahuldb;Integrated Security=True");

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
                dataGridView2.DataSource = dt;
                dataGridView2.AutoResizeRows();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.StackTrace);


            }




            MessageBox.Show("Some error");
            con.Close();
        }
    }
}
