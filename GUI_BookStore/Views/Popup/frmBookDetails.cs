using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BookStore.Views.Popup
{
    public partial class frmBookDetails : Form
    {
        public frmBookDetails()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myBookStoreDataSet);

        }

        private void frmBookDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myBookStoreDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.myBookStoreDataSet.Book);

        }
    }
}
