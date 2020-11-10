using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BookStore
{
    public class Book
    {
        public int BookID { get; private set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public bool IsLocalBook { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public Book()
        {

        }
        public Book (string Title, float Price, int Quantity, string Author, string Publisher, bool IsLocalBook, string Category, string Image)
        {
            this.Title = Title;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Author = Author;
            this.Publisher = Publisher;
            this.IsLocalBook = IsLocalBook;
            this.Category = Category;
            this.Image = Image;
        }
    }
}
