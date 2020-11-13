using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BookStore
{
    public class Account
    {
        public string Username { get; private set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Role { get; private set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Account()
        {

        }
        public Account (string Username, string Fullname, string Password, string Role, string Address, string Phone)
        {
            this.Username = Username;
            this.Fullname = Fullname;
            this.Password = Password;
            this.Role = Role;
            this.Address = Address;
            this.Phone = Phone;
        }
    }
}
