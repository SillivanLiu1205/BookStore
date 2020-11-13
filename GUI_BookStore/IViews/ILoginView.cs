using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_BookStore.IViews
{
    public interface ILoginView : IView
    {
        string Username { get; }
        string Password { get; }
    }
}
