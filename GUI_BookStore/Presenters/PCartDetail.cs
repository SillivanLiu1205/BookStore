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

        public Book FindBookByBookID(int BookID)
        {
            return Model.FindBookByBookID(BookID);
        }
    }
}
