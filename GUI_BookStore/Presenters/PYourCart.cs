using DTO_BookStore;
using GUI_BookStore.IViews;
using GUI_BookStore.UserControls;
using GUI_BookStore.Views.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_BookStore.Presenters
{
    public class PYourCart : Presenter<IYourCart>
    {
        /*public PYourCart(IYourCart view) : base(view)
        {
        }
        public void LoadForm(int CartID)
        {
            int SubTotal = 0;
            List<CartDetail> CartDetailList = Model.GetCartDetailByCartID(CartID);
            if (CartDetailList.Count == 0)
            {
                View.LabelMessage.Visible = true;
            }
            else
            {
                foreach (CartDetail c in CartDetailList)
                {
                    UC_CartDetail uc = new UC_CartDetail(c);
                    View.CartDetails.Controls.Add(uc);
                    SubTotal += c.CartDetailBook.Price * c.Quantity;
                }
                View.LabelMessage.Visible = false;
            }            
            View.LabelSubtotal.Text = SubTotal.ToString() + " đ";
        }*/
    }
}
