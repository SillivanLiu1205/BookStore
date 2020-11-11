using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_BookStore.IViews
{
    public interface IHomeView : IView
    {
        String SearchBy { get; }
        String SearchContext { get; }
        String Language { get; }
        String Category { get; }
    }
}
