﻿using System;
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
    public partial class UC_ManageBook : UserControl
    {
        public UC_ManageBook()
        {
            InitializeComponent();
        }

        private void UC_ManageBook_Load(object sender, EventArgs e)
        {
            cbxSearchBy.SelectedIndex = 1;
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myBookStoreDataSet);

        }
    }
}
