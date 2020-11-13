using DTO_BookStore;
using GUI_BookStore.IViews;
using GUI_BookStore.UserForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BookStore.Presenters
{
    public class PLogin : Presenter<ILoginView>
    {
        public PLogin(ILoginView view) : base(view)
        {
        }

        public Form Login()
        {
            Form view = null;
            string Username = View.Username;
            string Password = View.Password;

            Account account = Model.CheckLogin(Username, Password);
            if (account.Role == "Admin")
            {
                view = new frmAdmin(account);
            }
            else if (account.Role == "User")
            {
                view = new frmUser(account);
            }
            else throw new Exception("Username or Password is not correct");            
            return view;
        }
    }
}
