using DTO_BookStore;
using GUI_BookStore.IViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_BookStore.Presenters
{
    public class PCartDetail : Presenter<ICartDetail>
    {
        public PCartDetail(ICartDetail view) : base(view)
        {
        }

        public bool DeleteCartDetail(int CartDetailID)
        {
            return Model.DeleteCartDetail(CartDetailID);
        }

        public bool UpdateDateCartDetail(int CartDetailID, int Quantity)
        {
            return Model.UpdateCartDetailQuantity(CartDetailID, Quantity);
        }
    }
}
