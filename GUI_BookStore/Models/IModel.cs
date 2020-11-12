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
        bool AddNewAccount(Account account);
        bool UpdateAccount(Account NewAccount);

        //BookDAO
        List<Book> GetBooks(string SearchBy, string SearchContext, string Language, string CategoryID);
        Book FindBookByBookID(int BookID);
        bool AddNewBook(Book book);
        bool UpdateBook(Book book);
        bool DeleteBook(int BookID);

        //CategoryDAO
        List<string> GetAllCategoryName();
        int GetCategoryID(string CategoryName);
        string GetCategoryName(int CategoryID);

        //CardDAO
        Cart GetNotDoneCartByUsername(string Username);
        List<Cart> GetAllCartByUserame(string Username);
        List<Cart> GetAllCartByDateMothYear(DateTime Date, string SearchBy);

        //CartDetailDAO
        List<CartDetail> GetCartDetailByCartID(int CartID);
        bool DeleteCartDetail(int CartDetailID);
        bool UpdateCartDetailQuantity(int CartDetailID, int NewQuantity);
        bool AddNewCartDeailt(CartDetail cartDetail);
    }
}
