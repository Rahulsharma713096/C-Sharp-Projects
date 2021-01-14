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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();

        }

        private void reg_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
            //Registration Code
            /*
            
try{
string myConnection = "datasource=localhost;port=3306;username-root;password=root";
MySqlConnection myConn = new MySqlConnection(myConnection);
MySqlCommand SelectCommand = new MySqlCommand("select * from database.edata whereuser_name = '"+this.username_txt.Text+"' and password = '"+this.password_txt.Text+"';",myConn);
MySqlDataReader myReader;
 
myConn.Open();
myReader = SelectedCommand.ExecuteReader();
int count = 0;
 
while(myReader.Read())
{
count = count + 1;
}
 
if(count == 1)
{
this.Hide();
From2 f2 = new Form2();
f2.ShowDialog();
}
else if(count > 1)
{
MessageBox.Show("deplicate username and password"); 
}
else
{
MessageBox.Show("username and password aren't correct.. please try again");
}
}
catch(Exception ex)
{
MessageBox.Show(ex.Message);
}
             */

        }
    }
}
