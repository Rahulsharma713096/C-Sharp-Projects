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
   
    public partial class ShowData : Form
    {
        private SqlConnection con;

        public ShowData(SqlConnection con1)
        {
            InitializeComponent();
            con = con1;
        }

        private void ShowData_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoResizeRows();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda;
            SqlCommand cmd = new SqlCommand("select * from r1 ", con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeRows();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoInsert ai= new AutoInsert();
            ai.Show();
            this.Hide();
        }
    }
}
