using DTO_BookStore;
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

namespace GUI_BookStore.Views.Popup
{
    public partial class frmBookDetails : Form
    {
        public Book book;

        public frmBookDetails(Book book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void frmBookDetails_Load(object sender, EventArgs e)
        {
            string CategoryName = book.BookCategory.CategoryName;
            string Language = (book.IsLocalBook ? "Vietnamese" : "English");
            lbBookDetails.Text = "Title: " + book.Title +
                                 "\n\nPrice: " + book.Price +
                                 "\n\nQuantity in Storage: " + book.Quantity +
                                 "\n\nAuthor: " + book.Author +
                                 "\n\nPublisher: " + book.Publisher +
                                 "\n\nCategory: " + CategoryName +
                                 "\n\nLanguage: " + Language;
            pbxImage.Image = Image.FromFile(@"ImageData\" + book.Image);
        }
    }
}
