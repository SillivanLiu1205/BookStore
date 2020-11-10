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
        public string Username { get; set; }
        public string Status { get; set; }
        public Cart(int cartID, DateTime dateOrder, DateTime dateReceive, string username, string status)
        {
            CartID = cartID;
            DateOrder = dateOrder;
            DateReceive = dateReceive;
            Username = username;
            Status = status;
        }
        public Cart()
        {

        }
    }
}
