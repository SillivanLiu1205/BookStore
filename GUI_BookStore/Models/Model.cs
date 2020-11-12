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
        Services _Services = new Services();

        //Account
        public Account Login(string Username, string Password)
        {
            return _Services.CheckLogin(Username, Password);
        }
        public bool AddNewAccount(Account Account)
        {
            return _Services.AddNewAccount(Account);
        }
        public bool UpdateAccount(Account NewAccount)
        {
            return _Services.UpdateAccount(NewAccount);
        }

        //Book
        public List<Book> GetBooks(string SearchBy, string SearchContext, string Language, string CategoryID)
        {
            return _Services.GetBooks(SearchBy, SearchContext, Language, CategoryID);
        }
        public Book FindBookByBookID(int BookID)
        {
            return _Services.FindBookByBookID(BookID);
        }
        public bool AddNewBook(Book book)
        {
            return _Services.AddNewBook(book);
        }
        public bool UpdateBook(Book book)
        {
            return _Services.UpdateBook(book);
        }
        public bool DeleteBook(int BookID)
        {
            return _Services.DeleteBook(BookID);
        }

        //Category
        public List<string> GetAllCategoryName()
        {
            return _Services.GetAllCategoryName();
        }
        public int GetCategoryID(string CategoryName)
        {
            return _Services.GetCategoryID(CategoryName);
        }
        public string GetCategoryName(int CategoryID)
        {
            return _Services.GetCategoryName(CategoryID);
        }

        //Card
        public Cart GetNotDoneCartByUsername(string Username)
        {
            return _Services.GetNotDoneCartByUsername(Username);
        }
        public List<Cart> GetAllCartByUserame(string Username)
        {
            return _Services.GetAllCartByUserame(Username);
        }
        public List<Cart> GetAllCartByDateMothYear(DateTime Date, string SearchBy)
        {
            return _Services.GetAllCartByDateMothYear(Date, SearchBy);
        }
        
        //CardDetail
        public List<CartDetail> GetCartDetailByCartID(int CartID)
        {
            return _Services.GetCartDetailByCartID(CartID);
        }
        public bool DeleteCartDetail(int CartDetailID)
        {
            return _Services.DeleteCartDetail(CartDetailID);
        }
        public bool UpdateCartDetailQuantity(int CartDetailID, int NewQuantity)
        {
            return _Services.UpdateCartDetailQuantity(CartDetailID, NewQuantity);
        }
        public bool AddNewCartDeailt(CartDetail cartDetail)
        {
            return _Services.AddNewCartDeailt(cartDetail);
        }
    }
}
