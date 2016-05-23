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
            this.showInfoBtn = new System.Windows.Forms.Button();
            this.headerTxtBox = new System.Windows.Forms.RichTextBox();
            this.bodyTxtBox = new System.Windows.Forms.RichTextBox();
            this.logOutBtn = new System.Windows.Forms.Button();
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
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem1,
            this.addNotifierToolStripMenuItem,
            this.removeNotifierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 70);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // addNotifierToolStripMenuItem
            // 
            this.addNotifierToolStripMenuItem.Name = "addNotifierToolStripMenuItem";
            this.addNotifierToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addNotifierToolStripMenuItem.Text = "Add Notifier";
            // 
            // removeNotifierToolStripMenuItem
            // 
            this.removeNotifierToolStripMenuItem.Name = "removeNotifierToolStripMenuItem";
            this.removeNotifierToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.removeNotifierToolStripMenuItem.Text = "Remove Notifier";
            // 
            // showInfoBtn
            // 
            this.showInfoBtn.Location = new System.Drawing.Point(3, 405);
            this.showInfoBtn.Name = "showInfoBtn";
            this.showInfoBtn.Size = new System.Drawing.Size(496, 23);
            this.showInfoBtn.TabIndex = 2;
            this.showInfoBtn.Text = "Show Info";
            this.showInfoBtn.UseVisualStyleBackColor = true;
            this.showInfoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // headerTxtBox
            // 
            this.headerTxtBox.Location = new System.Drawing.Point(12, 12);
            this.headerTxtBox.Name = "headerTxtBox";
            this.headerTxtBox.Size = new System.Drawing.Size(496, 21);
            this.headerTxtBox.TabIndex = 6;
            this.headerTxtBox.Text = "";
            // 
            // bodyTxtBox
            // 
            this.bodyTxtBox.Location = new System.Drawing.Point(12, 39);
            this.bodyTxtBox.Name = "bodyTxtBox";
            this.bodyTxtBox.Size = new System.Drawing.Size(496, 260);
            this.bodyTxtBox.TabIndex = 7;
            this.bodyTxtBox.Text = "";
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(3, 434);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(496, 23);
            this.logOutBtn.TabIndex = 8;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 469);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.bodyTxtBox);
            this.Controls.Add(this.headerTxtBox);
            this.Controls.Add(this.showInfoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Notifier";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNotifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNotifierToolStripMenuItem;
        private System.Windows.Forms.Button showInfoBtn;
        private System.Windows.Forms.RichTextBox headerTxtBox;
        private System.Windows.Forms.RichTextBox bodyTxtBox;
        private System.Windows.Forms.Button logOutBtn;
    }
}

