using DTO_BookStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BookStore.IViews
{
    public interface IYourCart : IView
    {
        FlowLayoutPanel CartDetails { get; }
        Label LabelMessage { get; }
        Label LabelSubtotal { get; }
    }
}
