using ActiveUp.Net.Mail;
using E_Mail_Notifier_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailNotifierUI
{
    public partial class MainForm : Form
    {
        ProxyConnector pc = ProxyConnector.GetInstance();
        MessageCollection mc = new MessageCollection();
        private bool done;
        private Thread thread;
        private bool threadRunning;
        private static MainForm mf = null;
        private List<string> users = new List<string>();
        ActiveUp.Net.Mail.Message currentMessage;

        public List<string> UserList { get; set; }

        public static MainForm GetInstance()
        {
            if (mf == null)
            {
                mf = new MainForm();
            }
            return mf;
        }

        private MainForm()
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
            notifyIcon1.Visible = true;
            this.Focus();
            this.BringToFront();
        }


        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            bodyTxtBox.Text = currentMessage.BodyText.Text;
            subjectTxtBox.Text = currentMessage.Subject;
            senderTxtBox.Text = currentMessage.From.Name + ", <" + currentMessage.From.Email + "> " + "To <" + currentMessage.To.ElementAt(0) + ">";
            this.WindowState = FormWindowState.Normal;
            this.Focus();
            this.BringToFront();
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
            try
            {
                foreach (string user in UserList)
                {
                    pc.AgentManager.StopAndRemoveAgent(user);
                }
            }
            catch (Exception x)
            {
                Console.Write(x);
            }
            done = true;
            if(thread != null)
            {
                thread.Interrupt();
            }
            Application.Exit();
        }
        public void StartEmailChecker(string user)
        {
            users.Add(user);
            UserList = users;
            if (!threadRunning)
            {
                done = false;
                thread = new Thread(new ThreadStart(CheckForMail));
                thread.Start();
            }
        }

        private void CheckForMail()
        {
            threadRunning = true;
            while (!done)
            {
                mc = pc.AgentManager.GetAllFetchedEmails();
                foreach (ActiveUp.Net.Mail.Message m in mc)
                {
                    try
                    {
                        notifyIcon1.ShowBalloonTip(3000, "From " + m.From.Name + " to " + m.To.ElementAt(0).Name, m.Subject, ToolTipIcon.Info);
                        currentMessage = m;
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            bodyTxtBox.Text = currentMessage.BodyText.Text;
            subjectTxtBox.Text = currentMessage.Subject;
            senderTxtBox.Text = currentMessage.From.Name + ", <" + currentMessage.From.Email + "> " + "To <" + currentMessage.To.ElementAt(0) + ">";
            this.WindowState = FormWindowState.Normal;
            this.Focus();
            this.BringToFront();
        }

        private void addNotifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddLoginForm().Show();
        }

        private void removeNotifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RemoveLoginForm().Show();
        }
    }
}



