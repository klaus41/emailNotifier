using E_Mail_Notifier_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmailNotifierUI
{
    public partial class LoginForm : Form
    {
        ProxyConnector pc = ProxyConnector.GetInstance();
    
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            List<string> mailList = new List<string> { "inbox" };
            try
            {
                pc.AgentManager.AddAndStartSafeAgent(usernameTxtBox.Text, passwordTxtBox.Text, mailList);
                new MainForm().Show();
                this.Hide();
            }
            catch(Exception x)
            {
                MessageBox.Show("Error! Invalid username or password" + x);
            }
        }

    }
}
