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
        public int CartID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public CartDetail()
        {

        }
        public CartDetail(int cartDetailID, int cartID, int bookID, int quantity)
        {
            CartDetailID = cartDetailID;
            CartID = cartID;
            BookID = bookID;
            Quantity = quantity;
        }
    }
}
