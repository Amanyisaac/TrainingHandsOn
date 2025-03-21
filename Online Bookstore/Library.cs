using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Bookstore;
using static Reader;

namespace Online_Bookstore
{
    public class Library
    {
        private String LibraryName;
        private String LibraryAddress;
        private String LibraryEmail;
        private String LibraryPhoneNumber;
        private List<Book> books;
        private List<Reader> readers;
        private List<Librarian> librarians;
 
        public Library(string LibraryName, string LibraryAddress, string LibraryEmail, string LibraryPhoneNumber)
        {
            this.LibraryName = LibraryName;
            this.LibraryAddress = LibraryAddress;
            this.LibraryEmail = LibraryEmail;
            this.LibraryPhoneNumber = LibraryPhoneNumber;
            this.books = new List<Book>();
            this.readers = new List<Reader>();
            this.librarians = new List<Librarian>();
         }

    }
}
