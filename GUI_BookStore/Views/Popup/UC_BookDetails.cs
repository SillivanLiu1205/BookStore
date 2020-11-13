using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_BookStore;
using GUI_BookStore.UserControls;
using GUI_BookStore.UserForms;

namespace GUI_BookStore.Views.Popup
{
    public partial class UC_BookDetails : UserControl
    {
        Book book { get; set; }
        public UC_BookDetails(Book book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void UC_BookDetails_Load(object sender, EventArgs e)
        {
            this.ptbBok.Image = Image.FromFile(@"ImageData\"+book.Image);
            lbTitle.Text = book.Title;
            lbPrice.Text = book.Price.ToString()+" đ";
        }

        private void LoadDetailsForm()
        {
            frmBookDetails frm = new frmBookDetails(this.book);
            frmUser.loadPopupForm(frm);
        }

        private void ptbBok_Click(object sender, EventArgs e)
        {
            LoadDetailsForm();
        }

        private void ptbBok_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void ptbBok_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
