using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BookStore
{
    public class CartDetail
    {
        public int CartDetailID { get; private set; }
        public int Quantity { get; set; }
        public Cart CartDetailCart { get; set; }
        public Book CartDetailBook { get; set; }
        public CartDetail()
        {

        }
        public CartDetail(int cartDetailID, int quantity, Cart cartDetailCart, Book cartDetailBook)
        {
            this.CartDetailID = cartDetailID;            
            this.Quantity = quantity;
            this.CartDetailCart = cartDetailCart;
            this.CartDetailBook = cartDetailBook;
        }
    }
}
