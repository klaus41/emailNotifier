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
    public partial class RemoveLoginForm : Form
    {
        public RemoveLoginForm()
        {
            InitializeComponent();
        }

        private void removeLoginBtn_Click(object sender, EventArgs e)
        {
            //send email to BLL....
            this.Dispose();
        }
    }
}
