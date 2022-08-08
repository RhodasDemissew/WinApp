using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;
            if(username == "Rhodas" && password =="password")
            {
                Form1 form1 = new Form1 (username);
                Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }
    }
}
