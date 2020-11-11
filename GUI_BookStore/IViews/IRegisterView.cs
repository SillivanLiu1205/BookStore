using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_BookStore.IViews
{
    public interface IRegisterView : IView
    {
        string Username { get; }
        string Fullname { get; }
        string Password { get; }
        string ConfirmPassword { get; }
        string Role { get; }
        string Address { get; }
        string Phone { get; }
        string message { get; set; }
    }
}
