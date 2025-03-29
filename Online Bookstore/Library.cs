using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Bookstore;
namespace Online_Bookstore
{

    public class Library
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public List<Book> Books { get; private set; }
        public List<Reader> Readers { get; private set; }
        public List<Librarian> Librarians { get; private set; }

        public Library(string name, string address, string email, string phoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Books = new List<Book>();
            this.Readers = new List<Reader>();
            this.Librarians = new List<Librarian>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

    }
}

