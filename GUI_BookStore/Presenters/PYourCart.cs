using DTO_BookStore;
using GUI_BookStore.IViews;
using GUI_BookStore.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_BookStore.Presenters
{
    public class PYourCart : Presenter<IYourCart>
    {
        public PYourCart(IYourCart view) : base(view)
        {
        }
        public void LoadCartDetail(int CartID)
        {
            List<CartDetail> CartDetailList = mode
        }
    }
}
