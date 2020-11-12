using DAL_BookStore;
using DTO_BookStore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BookStore
{
    public class Services : IServices
    {
        public Services()
        {

        }

        //Account
        public Account checkLogin (string Username, string Password)
        {
            return AccountDAO.Instance.checkLogin(Username, Password);
        }
        public bool addNewAccount(Account account)
        {
            return AccountDAO.Instance.AddNewAccount(account);
        }

        //Book
        public List<Book> getBooks(string SearchBy, string SearchContext, string Language, string CategoryID)
        {
            return BookDAO.Instance.GetBooks(SearchBy, SearchContext, Language, CategoryID);
        }

        //Category
        public List<string> getAllCategoryName()
        {
            return CategoryDAO.Instance.getAllCategoryName();
        }
        public int getCategoryID(string CategoryName)
        {
            return CategoryDAO.Instance.getCategoryID(CategoryName);
        }
        public string getCategoryName(int CategoryID)
        {
            return CategoryDAO.Instance.getCategoryName(CategoryID);
        }
    }
}
