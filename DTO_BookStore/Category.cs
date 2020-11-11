using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BookStore
{
    public class Category
    {
        public int CategoryID { get; private set; }
        public string CategoryName { get; set; }

        public Category()
        {

        }

        public Category(int CategoryID , string Categoryname)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
        }
    }
}
