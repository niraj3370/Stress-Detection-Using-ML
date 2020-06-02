using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnomalyDetectionSample
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                MDIParent1 mDIParent1 = new MDIParent1();
                this.Hide();
                mDIParent1.Show();
            }
            else
            {
                txtUsername.Text = txtPassword.Text = "";
                MessageBox.Show("Invalid Username and Paswword");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
