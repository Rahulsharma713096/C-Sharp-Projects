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

namespace ConnectToDB
{
    public partial class Connection : Form
    {
        SqlConnection conn;
        string connectionString = @"Data Source=DESKTOP-94V18RE;Initial Catalog=rahuldb;Integrated Security=True ";
        public Connection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            MessageBox.Show("Connection is open");
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            this.Hide();
        }
    }
}
