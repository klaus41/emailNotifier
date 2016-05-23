using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace EmailNotifierUI
{
    public partial class LoginForm : Form
    {

        string username;
        string password;
    
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginCredentials.LoginCreds(usernameTxtBox.Text, passwordTxtBox.Text))
            {
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error! Invalid username or password");
            }
            /*username = "admin";
            password = "password";
            if(usernameTxtBox.Text == username && passwordTxtBox.Text == password)
            {
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error! Invalid username or password");
            }*/
        }

    }
}
