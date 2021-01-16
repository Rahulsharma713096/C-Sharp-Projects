using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowDataFromDatabase
{
    public partial class Show : Form
    {
        DataTable dt = new DataTable();
        public Show(DataTable dt1)
        {
            InitializeComponent();
            dt = dt1;

            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeRows();
        }

        private void Data_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetData_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }
    }
}
