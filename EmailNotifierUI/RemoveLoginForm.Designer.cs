namespace EmailNotifierUI
{
    partial class RemoveLoginForm
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
            this.removeLoginBtn = new System.Windows.Forms.Button();
            this.removeLoginUsernameTxtBox = new System.Windows.Forms.TextBox();
            this.removeLoginUsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeLoginBtn
            // 
            this.removeLoginBtn.Location = new System.Drawing.Point(12, 96);
            this.removeLoginBtn.Name = "removeLoginBtn";
            this.removeLoginBtn.Size = new System.Drawing.Size(260, 23);
            this.removeLoginBtn.TabIndex = 0;
            this.removeLoginBtn.Text = "Remove Login";
            this.removeLoginBtn.UseVisualStyleBackColor = true;
            this.removeLoginBtn.Click += new System.EventHandler(this.removeLoginBtn_Click);
            // 
            // removeLoginUsernameTxtBox
            // 
            this.removeLoginUsernameTxtBox.Location = new System.Drawing.Point(12, 25);
            this.removeLoginUsernameTxtBox.Name = "removeLoginUsernameTxtBox";
            this.removeLoginUsernameTxtBox.Size = new System.Drawing.Size(260, 20);
            this.removeLoginUsernameTxtBox.TabIndex = 1;
            // 
            // removeLoginUsernameLabel
            // 
            this.removeLoginUsernameLabel.AutoSize = true;
            this.removeLoginUsernameLabel.Location = new System.Drawing.Point(93, 9);
            this.removeLoginUsernameLabel.Name = "removeLoginUsernameLabel";
            this.removeLoginUsernameLabel.Size = new System.Drawing.Size(91, 13);
            this.removeLoginUsernameLabel.TabIndex = 2;
            this.removeLoginUsernameLabel.Text = "Username/E-mail:";
            // 
            // RemoveLoginForm
            // 
            this.AcceptButton = this.removeLoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.removeLoginUsernameLabel);
            this.Controls.Add(this.removeLoginUsernameTxtBox);
            this.Controls.Add(this.removeLoginBtn);
            this.Name = "RemoveLoginForm";
            this.Text = "Remove Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeLoginBtn;
        private System.Windows.Forms.TextBox removeLoginUsernameTxtBox;
        private System.Windows.Forms.Label removeLoginUsernameLabel;
    }
}