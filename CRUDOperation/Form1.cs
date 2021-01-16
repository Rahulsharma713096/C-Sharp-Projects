using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertForm i= new InsertForm();
            i.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete d =new Delete();
            d.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Show1 so = new Show1();
            so.Show();
            this.Hide();
            
        }
    }
}
