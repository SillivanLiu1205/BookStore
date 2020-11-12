using DTO_BookStore;
using GUI_BookStore.IViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_BookStore.Presenters
{
    public class PBookDetail : Presenter<IBookDetails>
    {
        public PBookDetail(IBookDetails view) : base(view)
        {
        }

        public string getCategoryName(int CategoryID)
        {
            return Model.getCategoryName(CategoryID);
        }
    }
}
