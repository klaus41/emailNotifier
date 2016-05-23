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
            //send down all info to BLL
            this.Dispose();
        }
    }
}
