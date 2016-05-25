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
    public partial class AddLoginForm : Form
    {
        MainForm mf = MainForm.GetInstance();
        ProxyConnector pc = ProxyConnector.GetInstance();
        
        public AddLoginForm()
        {
            InitializeComponent();
        }

        private void addManualConnectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addManualConnectionCheckBox.Checked == true)
            {
                newLoginPortLabel.Enabled = true;
                newLoginAddressLabel.Enabled = true;
                addressNewLoginTxtBox.Enabled = true;
                newLoginPortTxtBox.Enabled = true;
                sslCheckBox.Enabled = true;
            }
            if (addManualConnectionCheckBox.Checked == false)
            {
                newLoginPortLabel.Enabled = false;
                newLoginAddressLabel.Enabled = false;
                addressNewLoginTxtBox.Enabled = false;
                newLoginPortTxtBox.Enabled = false;
                sslCheckBox.Enabled = false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            List<string> mailList = new List<string> { "inbox" };
            try
            {
                if(addManualConnectionCheckBox.Checked == false)
                {
                    pc.AgentManager.AddAndStartAgent(usernameNewLoginTxtBox.Text, passwordNewLoginTxtBox.Text, mailList);
                }
                else
                {
                    int portNumber = int.Parse(newLoginPortTxtBox.Text);
                    pc.AgentManager.AddAndStartAgent(usernameNewLoginTxtBox.Text, passwordNewLoginTxtBox.Text, mailList, addressNewLoginTxtBox.Text, portNumber, sslCheckBox.Checked);
                }
                mf.StartEmailChecker(usernameNewLoginTxtBox.Text);
                this.Hide();
                mf.WindowState = FormWindowState.Minimized;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error! Invalid username or password");
            }
        }        
    }
}
