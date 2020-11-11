using DTO_BookStore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BookStore
{
    public interface IServices
    {
        //AcountDAO
        Account checkLogin(String Username, string Password);
        bool addNewAccount(Account account);

        //BookDAO
        List<Book> getBooks(string SearchBy, string SearchContext, string Language, int CategoryID);

        //CategoryDAO
        List<string> getAllCategoryName();
    }
}
