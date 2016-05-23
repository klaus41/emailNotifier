using ActiveUp.Net.Mail;
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
    public partial class MainForm : Form
    {
        ProxyConnector pc = ProxyConnector.GetInstance();
        MessageCollection mc = new MessageCollection();


        public MainForm()
        {            
            InitializeComponent();
            
        }

        

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
        

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new LoginForm().Show();
        }

        private void addLoginBtn_Click(object sender, EventArgs e)
        {
            new AddLoginForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RemoveLoginForm().Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkMailBtn_Click(object sender, EventArgs e)
        {

                mc = pc.AgentManager.GetAllFetchedEmails();
                foreach (ActiveUp.Net.Mail.Message m in mc)
                {
                    notifyIcon1.ShowBalloonTip(3000, m.From.Name, m.BodyText.Text, ToolTipIcon.Info);
                    bodyTxtBox.Text = m.BodyText.Text;
                    subjectTxtBox.Text = m.Subject;
                    senderTxtBox.Text = m.From.Name + ", <" + m.From.Email + ">";
                }
        }
    }
}
