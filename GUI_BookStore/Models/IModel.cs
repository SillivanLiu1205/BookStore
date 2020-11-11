using DTO_BookStore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_BookStore.Models
{
    public interface IModel
    {
        //AccountDAO
        Account Login(string Username, string Password);
        bool addNewAccount(Account account);

        //BookDAO
        List<Book> getBooks(string SearchBy, string SearchContext, string Language, int CategoryID);

        //CategoryDAO
        List<string> getAllCategoryName();
    }
}
