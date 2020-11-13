using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BookStore
{
    public class Cart
    {        
        public int CartID { get; private set; }
        public DateTime DateOrder { get; set; }
        public DateTime DateReceive { get; set; }        
        public string Status { get; set; }
        public Account CartAccount { get; set; }
        public Cart(int cartID, DateTime dateOrder, DateTime dateReceive, string status, Account CartAccount)
        {
            this.CartID = cartID;
            this.DateOrder = dateOrder;
            this.DateReceive = dateReceive;
            this.Status = status;
            this.CartAccount = CartAccount;
        }
        public Cart()
        {

        }
    }
}
