using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
 namespace MyBookStore;


internal class MainClass
{
    static void Main(string[] args)
    {
          User user = new User("Amany", 20 , "12345678", "amany.isaac@gmail.com");
        MyBookStore book = new MyBookStore("Atomic Habits", 1, "argumentive", 20, new Author("James Clear"));
         user.AddBook(book);
        user.DisplayBooks();

        Console.WriteLine("*****************************");

        Order order = new Order("Nacr City", user);
        order.display_info();
    }
}
 