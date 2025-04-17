using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{
    public class Book
    {
        public String Title { get; private set; }
         public String Publisher { get; private set; }
        public int Pages { get; private set; }
        public int Type { get; private set; }
        public double Price { get; private set; }
        public List<BookAuthor> Authors { get; private set; }



        public Book(String title,  String publisher, int type, int pages, double price)
        {
            this.Title = title;
            this.Publisher =publisher;
            this.Type = type;
            this.Pages = pages;
            this.Price = price;
            this.Authors = new List<BookAuthor>();
        }

    }
}
