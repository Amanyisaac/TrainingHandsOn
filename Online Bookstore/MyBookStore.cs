using MyBookStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;
using System;
namespace MyBookStore;


public class MyBookStore
{
private string name;
private int numberOfBooks;
private string type;
private float price;
private Author author;


public MyBookStore(string name, int numberOfBooks, string type, float price, Author author)
{
    this.name = name;
    this.numberOfBooks = numberOfBooks;
    this.type = type;
    this.price = price;
    this.author = author;
}

public string Name
{
    get { 
            return name;
        }
    set {
            name = value;
        }
}

public int NumberOfBooks
{
    get {
            return numberOfBooks;
        }
    set {
            numberOfBooks = value; 
        }
}

public string Type
{
    get {
            return type; 
        }
    set {
            type = value;
        }
}

public float Price
{
    get {
            return price; 
        }
    set {
            price = value;
        }
}

public Author Author
{
    get { 
            return author;
        }
    set {
            author = value;
        }
}

public void display_info()
{
    Console.WriteLine("Book Name: " + name);
    Console.WriteLine("Number of Books: " + numberOfBooks);
    Console.WriteLine("Type: " + type);
    Console.WriteLine("Price: " + price);
    Console.WriteLine("Author Name: " + author.Name);
}
}


