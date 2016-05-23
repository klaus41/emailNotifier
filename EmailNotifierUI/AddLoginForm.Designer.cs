namespace EmailNotifierUI
{
    partial class AddLoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.PasswordNewUserLabel = new System.Windows.Forms.Label();
            this.usernameNewUserLabel = new System.Windows.Forms.Label();
            this.passwordNewLoginTxtBox = new System.Windows.Forms.TextBox();
            this.usernameNewLoginTxtBox = new System.Windows.Forms.TextBox();
            this.addManualConnectionCheckBox = new System.Windows.Forms.CheckBox();
            this.newLoginAddressLabel = new System.Windows.Forms.Label();
            this.addressNewLoginTxtBox = new System.Windows.Forms.TextBox();
            this.newLoginPortTxtBox = new System.Windows.Forms.TextBox();
            this.newLoginPortLabel = new System.Windows.Forms.Label();
            this.sslCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(12, 229);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(360, 23);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Add New Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // PasswordNewUserLabel
            // 
            this.PasswordNewUserLabel.AutoSize = true;
            this.PasswordNewUserLabel.Location = new System.Drawing.Point(174, 48);
            this.PasswordNewUserLabel.Name = "PasswordNewUserLabel";
            this.PasswordNewUserLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordNewUserLabel.TabIndex = 8;
            this.PasswordNewUserLabel.Text = "Password:";
            // 
            // usernameNewUserLabel
            // 
            this.usernameNewUserLabel.AutoSize = true;
            this.usernameNewUserLabel.Location = new System.Drawing.Point(172, 9);
            this.usernameNewUserLabel.Name = "usernameNewUserLabel";
            this.usernameNewUserLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameNewUserLabel.TabIndex = 7;
            this.usernameNewUserLabel.Text = "Username:";
            // 
            // passwordNewLoginTxtBox
            // 
            this.passwordNewLoginTxtBox.Location = new System.Drawing.Point(12, 64);
            this.passwordNewLoginTxtBox.Name = "passwordNewLoginTxtBox";
            this.passwordNewLoginTxtBox.PasswordChar = '*';
            this.passwordNewLoginTxtBox.Size = new System.Drawing.Size(360, 20);
            this.passwordNewLoginTxtBox.TabIndex = 6;
            // 
            // usernameNewLoginTxtBox
            // 
            this.usernameNewLoginTxtBox.Location = new System.Drawing.Point(12, 25);
            this.usernameNewLoginTxtBox.Name = "usernameNewLoginTxtBox";
            this.usernameNewLoginTxtBox.Size = new System.Drawing.Size(360, 20);
            this.usernameNewLoginTxtBox.TabIndex = 5;
            // 
            // addManualConnectionCheckBox
            // 
            this.addManualConnectionCheckBox.AutoSize = true;
            this.addManualConnectionCheckBox.Location = new System.Drawing.Point(12, 109);
            this.addManualConnectionCheckBox.Name = "addManualConnectionCheckBox";
            this.addManualConnectionCheckBox.Size = new System.Drawing.Size(140, 17);
            this.addManualConnectionCheckBox.TabIndex = 10;
            this.addManualConnectionCheckBox.Text = "Add Manual Connection";
            this.addManualConnectionCheckBox.UseVisualStyleBackColor = true;
            this.addManualConnectionCheckBox.CheckedChanged += new System.EventHandler(this.addManualConnectionCheckBox_CheckedChanged);
            // 
            // newLoginAddressLabel
            // 
            this.newLoginAddressLabel.AutoSize = true;
            this.newLoginAddressLabel.Enabled = false;
            this.newLoginAddressLabel.Location = new System.Drawing.Point(174, 135);
            this.newLoginAddressLabel.Name = "newLoginAddressLabel";
            this.newLoginAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.newLoginAddressLabel.TabIndex = 12;
            this.newLoginAddressLabel.Text = "Address:";
            // 
            // addressNewLoginTxtBox
            // 
            this.addressNewLoginTxtBox.Enabled = false;
            this.addressNewLoginTxtBox.Location = new System.Drawing.Point(12, 151);
            this.addressNewLoginTxtBox.Name = "addressNewLoginTxtBox";
            this.addressNewLoginTxtBox.PasswordChar = '*';
            this.addressNewLoginTxtBox.Size = new System.Drawing.Size(280, 20);
            this.addressNewLoginTxtBox.TabIndex = 11;
            // 
            // newLoginPortTxtBox
            // 
            this.newLoginPortTxtBox.Enabled = false;
            this.newLoginPortTxtBox.Location = new System.Drawing.Point(298, 151);
            this.newLoginPortTxtBox.Name = "newLoginPortTxtBox";
            this.newLoginPortTxtBox.PasswordChar = '*';
            this.newLoginPortTxtBox.Size = new System.Drawing.Size(74, 20);
            this.newLoginPortTxtBox.TabIndex = 13;
            // 
            // newLoginPortLabel
            // 
            this.newLoginPortLabel.AutoSize = true;
            this.newLoginPortLabel.Enabled = false;
            this.newLoginPortLabel.Location = new System.Drawing.Point(321, 135);
            this.newLoginPortLabel.Name = "newLoginPortLabel";
            this.newLoginPortLabel.Size = new System.Drawing.Size(29, 13);
            this.newLoginPortLabel.TabIndex = 14;
            this.newLoginPortLabel.Text = "Port:";
            // 
            // sslCheckBox
            // 
            this.sslCheckBox.AutoSize = true;
            this.sslCheckBox.Enabled = false;
            this.sslCheckBox.Location = new System.Drawing.Point(12, 177);
            this.sslCheckBox.Name = "sslCheckBox";
            this.sslCheckBox.Size = new System.Drawing.Size(46, 17);
            this.sslCheckBox.TabIndex = 15;
            this.sslCheckBox.Text = "SSL";
            this.sslCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 264);
            this.Controls.Add(this.sslCheckBox);
            this.Controls.Add(this.newLoginPortLabel);
            this.Controls.Add(this.newLoginPortTxtBox);
            this.Controls.Add(this.newLoginAddressLabel);
            this.Controls.Add(this.addressNewLoginTxtBox);
            this.Controls.Add(this.addManualConnectionCheckBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.PasswordNewUserLabel);
            this.Controls.Add(this.usernameNewUserLabel);
            this.Controls.Add(this.passwordNewLoginTxtBox);
            this.Controls.Add(this.usernameNewLoginTxtBox);
            this.Name = "AddLoginForm";
            this.Text = "addLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label PasswordNewUserLabel;
        private System.Windows.Forms.Label usernameNewUserLabel;
        private System.Windows.Forms.TextBox passwordNewLoginTxtBox;
        private System.Windows.Forms.TextBox usernameNewLoginTxtBox;
        private System.Windows.Forms.CheckBox addManualConnectionCheckBox;
        private System.Windows.Forms.Label newLoginAddressLabel;
        private System.Windows.Forms.TextBox addressNewLoginTxtBox;
        private System.Windows.Forms.TextBox newLoginPortTxtBox;
        private System.Windows.Forms.Label newLoginPortLabel;
        private System.Windows.Forms.CheckBox sslCheckBox;
    }
}