using DTO_BookStore;
using GUI_BookStore.IViews;
using GUI_BookStore.UserControls;
using System;
using System.Windows.Forms;

namespace GUI_BookStore.UserForms
{
    public partial class frmUser : Form
    {
        int panelWidth;
        bool isCollapsed;
        Account account;
        public frmUser(Account account)
        {
            InitializeComponent();
            this.account = account;
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
                if (pnLeft.Width <= 62)
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

        private void btnMoveSide_Click(object sender, EventArgs e)
        {
            timerCollapse.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home c = new UC_Home();
            moveSidePanel(btnHome);
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }

        private void btnYourCart_Click(object sender, EventArgs e)
        {
            UC_YourCart c = new UC_YourCart();
            moveSidePanel(btnYourCart);
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            UC_History c = new UC_History();
            moveSidePanel(btnHistory);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void moveSidePanel(Control btn)
        {
            pnSide.Top = btn.Top;
            pnSide.Height = btn.Height;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Welcome " + account.Fullname;
            UC_Home c = new UC_Home();
            panelWidth = pnLeft.Width;
            isCollapsed = false;
            timerTime.Start();
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }
    }
}
