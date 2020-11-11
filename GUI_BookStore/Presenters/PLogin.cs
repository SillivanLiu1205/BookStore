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
            Form view;
            string Username = View.Username;
            string Password = View.Password;

            Account account = Model.Login(Username, Password);
            try
            {
                if (account.Role == "Admin")
                {
                    view = new frmAdmin(account);
                }
                else if (account.Role == "User")
                {
                    view = new frmUser(account);
                }
                else throw new Exception("Username or Password is not correct");
            }catch (Exception e)
            {
                throw new Exception("Username or Password is null");
            }
            return view;
        }
    }
}
