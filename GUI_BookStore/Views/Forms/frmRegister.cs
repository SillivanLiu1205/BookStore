using GUI_BookStore.IViews;
using GUI_BookStore.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BookStore.UserForms
{
    public partial class frmRegister : Form, IRegisterView
    {        
        public string Username => txtUserName.Text;

        public string Fullname => txtFullname.Text;

        public string Password => txtPassword.Text;

        public string ConfirmPassword => txtConfirmPassword.Text;

        public string Role => "User";

        public string Address => txtAddress.Text;

        public string Phone => txtPhone.Text;

        private PRegister registerPresenter;

        public frmRegister()
        {
            InitializeComponent();
            registerPresenter = new PRegister(this);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                bool addResult = registerPresenter.AddNewAccount();
                if (addResult)
                {
                    MessageBox.Show("Successfull");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Register Fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sign Up Fail", ex.Message);
            }
        }

        private void llbSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
