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
        public Account CheckLogin (string Username, string Password)
        {
            return AccountDAO.Instance.CheckLogin(Username, Password);
        }
        public bool AddNewAccount(Account Account)
        {
            return AccountDAO.Instance.AddNewAccount(Account);
        }
        public bool UpdateAccount(Account NewAccount)
        {
            return AccountDAO.Instance.UpdateAccount(NewAccount);
        }
        public DataTable FindAccount(string SearchBy, string SearchContext)
        {
            return AccountDAO.Instance.FindAccount(SearchBy, SearchContext);
        }

        //Book
        public List<Book> GetBooks(string SearchBy, string SearchContext, string Language, string CategoryID)
        {
            return BookDAO.Instance.GetBooks(SearchBy, SearchContext, Language, CategoryID);
        }
        public Book FindBookByBookID(int BookID)
        {
            return BookDAO.Instance.FindBookByID(BookID);
        }
        public bool UpdateBook(Book book)
        {
            return BookDAO.Instance.UpdateBook(book);
        }
        public bool DeleteBook(int BookID)
        {
            return BookDAO.Instance.DeleteBook(BookID);
        }
        public bool AddNewBook (Book book)
        {
            return BookDAO.Instance.AddNewBook(book);
        }
        //Category
        public List<string> GetAllCategoryName()
        {
            return CategoryDAO.Instance.GetAllCategoryName();
        }
        public Category GetCategoryByName(string CategoryName)
        {
            return CategoryDAO.Instance.GetCategoryByName(CategoryName);
        }
        public Category GetCategoryByID(int CategoryID)
        {
            return CategoryDAO.Instance.GetCategoryByID(CategoryID);
        }

        //Cart
        public List<Cart> GetAllCartByUserame(string Username)
        {
            return CartDAO.Instance.GetAllCartByUserame(Username);
        }
        public List<Cart> GetAllCartByDateMothYear(DateTime Date, string SearchBy)
        {
            return CartDAO.Instance.GetAllCartByDateMothYear(Date, SearchBy);
        }

        //CartDetail
        public List<CartDetail> GetCartDetailByCartID(int CartID)
        {
            return CartDetailDAO.Instance.GetCartDetailByCartID(CartID);
        }
        public bool DeleteCartDetail(int CartDetailID)
        {
            return CartDetailDAO.Instance.DeleteCartDetail(CartDetailID);
        }
        public bool UpdateCartDetailQuantity(int CartDetailID, int NewQuantity)
        {
            return CartDetailDAO.Instance.UpdateCartDetailQuantity(CartDetailID, NewQuantity);
        }
        public bool AddNewCartDeailt(CartDetail cartDetail)
        {
            return CartDetailDAO.Instance.AddNewCartDeailt(cartDetail);
        }
    }
}
