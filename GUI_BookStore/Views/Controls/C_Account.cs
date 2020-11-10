using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_BookStore.UserForms;

namespace GUI_BookStore.UserControls
{
    public partial class UC_Account : UserControl
    {
        private Form frm;
        public UC_Account(Form f)
        {
            InitializeComponent();
            this.frm = f;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            /*UC_Account_ChangePassword c = new UC_Account_ChangePassword();
            pn.Controls.Clear();
            pn.Controls.Add(c);*//*
            this.*/
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Your information was updated");
                btnSaveChange.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update Fail");
                btnSaveChange.Enabled = false;
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frm.Close();
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            if (!txtFullname.Text.Equals(String.Empty))
            {
                btnSaveChange.Enabled = true;
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (!txtAddress.Text.Equals(string.Empty))
            {
                btnSaveChange.Enabled = true;
            }
        }
    }
}
