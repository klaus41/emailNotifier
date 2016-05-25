namespace EmailNotifierUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNotifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNotifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectTxtBox = new System.Windows.Forms.RichTextBox();
            this.bodyTxtBox = new System.Windows.Forms.RichTextBox();
            this.senderTxtBox = new System.Windows.Forms.RichTextBox();
            this.addLoginBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "You have now minimized the e-mail notifier. The application will keep runing in t" +
    "he background to keep you updated with new e-mails.";
            this.notifyIcon1.BalloonTipTitle = "Email Notifier";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Email Notifier";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem1,
            this.addNotifierToolStripMenuItem,
            this.removeNotifierToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 92);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(224, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // addNotifierToolStripMenuItem
            // 
            this.addNotifierToolStripMenuItem.Name = "addNotifierToolStripMenuItem";
            this.addNotifierToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.addNotifierToolStripMenuItem.Text = "Add Notifier";
            this.addNotifierToolStripMenuItem.Click += new System.EventHandler(this.addNotifierToolStripMenuItem_Click);
            // 
            // removeNotifierToolStripMenuItem
            // 
            this.removeNotifierToolStripMenuItem.Name = "removeNotifierToolStripMenuItem";
            this.removeNotifierToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.removeNotifierToolStripMenuItem.Text = "Remove Notifier";
            this.removeNotifierToolStripMenuItem.Click += new System.EventHandler(this.removeNotifierToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.logOutToolStripMenuItem.Text = "Show Latest Recieved E-Mail";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // subjectTxtBox
            // 
            this.subjectTxtBox.Location = new System.Drawing.Point(12, 65);
            this.subjectTxtBox.Name = "subjectTxtBox";
            this.subjectTxtBox.Size = new System.Drawing.Size(496, 21);
            this.subjectTxtBox.TabIndex = 6;
            this.subjectTxtBox.Text = "";
            // 
            // bodyTxtBox
            // 
            this.bodyTxtBox.Location = new System.Drawing.Point(12, 105);
            this.bodyTxtBox.Name = "bodyTxtBox";
            this.bodyTxtBox.Size = new System.Drawing.Size(496, 294);
            this.bodyTxtBox.TabIndex = 7;
            this.bodyTxtBox.Text = "";
            // 
            // senderTxtBox
            // 
            this.senderTxtBox.Location = new System.Drawing.Point(12, 25);
            this.senderTxtBox.Name = "senderTxtBox";
            this.senderTxtBox.Size = new System.Drawing.Size(496, 21);
            this.senderTxtBox.TabIndex = 9;
            this.senderTxtBox.Text = "";
            // 
            // addLoginBtn
            // 
            this.addLoginBtn.Location = new System.Drawing.Point(12, 405);
            this.addLoginBtn.Name = "addLoginBtn";
            this.addLoginBtn.Size = new System.Drawing.Size(496, 23);
            this.addLoginBtn.TabIndex = 10;
            this.addLoginBtn.Text = "Add Login";
            this.addLoginBtn.UseVisualStyleBackColor = true;
            this.addLoginBtn.Click += new System.EventHandler(this.addLoginBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(496, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Remove Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "From <Sender> To <Recipient>:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Message Body:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addLoginBtn);
            this.Controls.Add(this.senderTxtBox);
            this.Controls.Add(this.bodyTxtBox);
            this.Controls.Add(this.subjectTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Notifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNotifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNotifierToolStripMenuItem;
        private System.Windows.Forms.RichTextBox subjectTxtBox;
        private System.Windows.Forms.RichTextBox bodyTxtBox;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox senderTxtBox;
        private System.Windows.Forms.Button addLoginBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

