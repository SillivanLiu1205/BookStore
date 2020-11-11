using GUI_BookStore.IViews;
using GUI_BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_BookStore.Presenters
{
    public class Presenter<T> where T : IView
    {
        protected static IModel Model { get; private set; }
        protected T View { get; set; }

        static Presenter()
        {
            Model = new Model();
        }

        public Presenter(T view)
        {
            View = view;
        }
    }
}
