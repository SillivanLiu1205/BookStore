using DTO_BookStore;
using GUI_BookStore.UserControls;
using GUI_BookStore.Views.Popup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_BookStore.Presenters
{
    public class PHome : Presenter<UC_Home>
    {
        public PHome(UC_Home view) : base(view)
        {
            
        }

        public void getBooks()
        {
            List<UC_BookDetails> BookViewList = new List<UC_BookDetails>();
            List<Book> BookList = new List<Book>();
            foreach(Book book in BookList)
            {
                UC_BookDetails uc = new UC_BookDetails(book);
            }
        }

        public void getAllCategoryName()
        {
            List<string> CategoryList = Model.getAllCategoryName();
            foreach(string c in CategoryList)
            {
                View.clbCategory.Items.Add(c);
            }
        }
    }
}
