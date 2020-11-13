using GUI_BookStore.IViews;
using GUI_BookStore.Presenters;
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
    public partial class frmLogin : Form, ILoginView
    {
        private PLogin loginPresenter { get; set; }
        public string Username {
            get
            {
                return txtUserName.Text;
            }            
        }
        public string Password
        {
            get
            {
                return txtPassword.Text;
            }            
        }

        public frmLogin()
        {
            InitializeComponent();
            loginPresenter = new PLogin(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Form view = loginPresenter.Login();
                this.Hide();
                view.ShowDialog();
                this.Show();
                cleanScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister f = new frmRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
            cleanScreen();
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
