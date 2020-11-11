using BUS_BookStore;
using DTO_BookStore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GUI_BookStore.Models
{
    public class Model : IModel
    {
        Services services = new Services();

        //Account
        public Account Login(string Username, string Password)
        {
            return services.checkLogin(Username, Password);
        }

        public bool addNewAccount(Account account)
        {
            return services.addNewAccount(account);
        }

        //Book
        public List<Book> getBooks(string SearchBy, string SearchContext, string Language, int CategoryID)
        {
            return services.getBooks(SearchBy, SearchContext, Language, CategoryID);
        }

        //Category
        public List<string> getAllCategoryName()
        {
            return services.getAllCategoryName();
        }
    }
}
