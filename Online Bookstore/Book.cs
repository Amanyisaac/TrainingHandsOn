using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{
    public  class Book
    {
        private String title;
        private String author;
        private String genre;
        private String publisher;
        private int types;
        private int pages;
        private double price;
         private List<Book> books;
        public Book(string title, string author, string genre, string publisher, int types, int pages, double price)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.publisher = publisher;
            this.types = types;
            this.pages = pages;
            this.price = price;
            this.books = new List<Book>();

        }

    }
}
