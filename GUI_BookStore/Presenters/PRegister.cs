using DTO_BookStore;
using GUI_BookStore.IViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_BookStore.Presenters
{
    public class PRegister : Presenter<IRegisterView>
    {
        public PRegister(IRegisterView view) : base(view)
        {
        }

        public bool addNewAccount()
        {
            string Username = View.Username;
            string Fullname = View.Fullname;
            string Password = View.Password;
            string ConfirmPassword = View.ConfirmPassword;
            string Role = View.Role;
            string Address = View.Address;
            string Phone = View.Phone;

            if (Password.Equals(ConfirmPassword))
            {
                return Model.addNewAccount(new Account(Username, Fullname, Password, Role, Address, Phone));
            }
            else
            {
                View.message = "Password and Confirm Password is not equal";
                return false;
            }
        }
    }
}
