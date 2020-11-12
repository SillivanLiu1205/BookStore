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
    public partial class frmBookDetails : Form, IBookDetails
    {
        private PBookDetail bookDetailPresenter;
        public Book book { get; set; }

        public frmBookDetails(Book book)
        {
            InitializeComponent();
            bookDetailPresenter = new PBookDetail(this);
            this.book = book;
        }

        private void frmBookDetails_Load(object sender, EventArgs e)
        {
            string CategoryName = bookDetailPresenter.getCategoryName(book.Category);
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
