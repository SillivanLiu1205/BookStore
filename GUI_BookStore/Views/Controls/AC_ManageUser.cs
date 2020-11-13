using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BookStore.UserControls
{
    public partial class UC_ManageUser : UserControl
    {
        public string SearchBy { get => cbxSearchBy.SelectedItem.ToString();}
        public string SearchContext { get => txtSearch.Text; }
        public UC_ManageUser()
        {
            InitializeComponent();
        }

        private void UC_ManageUser_Load(object sender, EventArgs e)
        {
            cbxSearchBy.SelectedIndex = 1;
        }
}
