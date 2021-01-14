using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comvision_TestProjecct
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Close ();
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = Email.Text;
            string pwd = password.Text;

            if(id=="123"&& pwd=="123")
            {
                Index i = new Index();
                i.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password or Email is incorrect");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Email.Text="";
            password.Text="";
        }
    }
}
