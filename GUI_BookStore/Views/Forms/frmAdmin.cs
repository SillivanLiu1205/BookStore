using DTO_BookStore;
using GUI_BookStore.IViews;
using GUI_BookStore.UserControls;
using System;
using System.Windows.Forms;

namespace GUI_BookStore.UserForms
{
    public partial class frmAdmin : Form
    {
        int panelWidth;
        bool isCollapsed;
        Account account;
        public frmAdmin(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Welcome " + account.Fullname;
            UC_ManageBook c = new UC_ManageBook();
            panelWidth = pnLeft.Width;
            isCollapsed = false;
            timerTime.Start();
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            timerCollapse.Start();
        }

        private void timerCollapse_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnLeft.Width = pnLeft.Width + 10;
                if (pnLeft.Width >= panelWidth)
                {
                    timerCollapse.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                pnLeft.Width = pnLeft.Width - 10;
                if(pnLeft.Width <= 62)
                {
                    timerCollapse.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbTime.Text = dt.ToString("HH:MM:ss");
        }

        private void btnMangeBook_Click(object sender, EventArgs e)
        {
            UC_ManageBook c = new UC_ManageBook();
            moveSidePanel(btnMangeBook);
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            UC_ManageUser c = new UC_ManageUser();
            moveSidePanel(btnManageUser);
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            UC_Income c = new UC_Income();
            moveSidePanel(btnIncome);
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }

        private void btnNewAdmin_Click(object sender, EventArgs e)
        {
            UC_NewAdmin c = new UC_NewAdmin();
            moveSidePanel(btnNewAdmin);
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            UC_Account c = new UC_Account(this);
            moveSidePanel(btnAccount);
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }

        private void moveSidePanel(Control btn)
        {
            pnSide.Top = btn.Top;
            pnSide.Height = btn.Height;
        }
    }
}
