 using System;
 using MyBookStore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
namespace MyBookStore;
public class User
{
    private string name;
    private int age;
    private string number;
    private string email;
    private List<MyBookStore> books;

    public User(String name, int age, string number, string email)
    {
        this.name = name;
        this.age = age;
        this.number = number;
        this.email = email;
        books = new List<MyBookStore>();
    }

    public void SetName(string n)
    {
        name = n;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAge(int a)
    {
        age = a;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetNumber(string nu)
    {
        number = nu;
    }

    public string GetNumber()
    {
        return number;
    }

    public void SetEmail(string e)
    {
        email = e;
    }

    public string GetEmail()
    {
        return email;
    }

    public void AddBook(MyBookStore b)
    {
        books.Add(b);
    }




    public void DisplayBooks()
    {
        for (int i = 0; i < books.Count; i++)
        {
            books[i].display_info();
        }
    }
 
}