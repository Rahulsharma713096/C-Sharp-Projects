using System;
using System.Windows.Forms;

namespace Comvision_TestProjecct
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Close();
        }
    }
}
