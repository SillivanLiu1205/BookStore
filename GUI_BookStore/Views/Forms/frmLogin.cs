using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BookStore.UserForms
{
    public partial class frmLogin : Form
    {
        private string _role;
        private string _message;
        public string UserName {
            get
            {
                return txtUserName.Text;
            }
            set
            {
                txtUserName.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }
        public string Role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
            }
        }
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("User"))
            {
                frmUser f = new frmUser();
                this.Hide();
                cleanScreen();
                f.ShowDialog();
                this.Show();
            }
            else if (txtUserName.Text.Equals("Admin"))
            {
                frmAdmin f = new frmAdmin();
                this.Hide();
                cleanScreen();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Login Fail");
                cleanScreen();
            }
        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister f = new frmRegister();
            this.Hide();
            cleanScreen();
            f.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cleanScreen()
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}
