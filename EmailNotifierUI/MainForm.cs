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

        
        public MainForm()
        {
            InitializeComponent();
            /*senderTxtBox.Text = BLL.emailInfo.getSender();
            subjectTxtBox.Text = BLL.emailInfo.getSubject();
            bodyTxtBox.Text = BLL.emailInfo.getBody();*/
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
    }
}
