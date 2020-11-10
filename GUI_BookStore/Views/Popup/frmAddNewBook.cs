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
    public partial class frmAddNewBook : Form
    {
        public frmAddNewBook()
        {
            InitializeComponent();
        }

        private void frmAddNewBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myBookStoreDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.myBookStoreDataSet.Category);

        }
    }
}
