using DataStrutures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
 
public class LinkedListDS
{
    public Node Head { get; set; }
    public Node Tail { get; set; }

    public LinkedListDS()
    {
        Head = null;
        Tail = null;
    }

    public bool Contains(int value)
    {
        Node temp = Head;
        while (temp != null)
        {
            if (temp.Value == value)
            {
                return true;
            }
            temp = temp.next;
        }
        return false;
    }

    public void AddFirst(int value)
    {
        Node newNode = new Node(value);
        newNode.next = Head;
        Head = newNode;
        if (Tail == null) Tail = newNode;
    }

    public void AddLast(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.next = newNode;
            Tail = newNode;
        }
    }

    public void AddAfter(int value, int newValue)
    {
        if (Contains(value))
        {
            Node newNode = new Node(newValue);
            Node temp = Head;
            while (temp.Value != value)
            {
                temp = temp.next;
            }
            newNode.next = temp.next;
            temp.next = newNode;
            if (Tail == temp) Tail = newNode;
        }
        else
        {
            Console.WriteLine("Value not found in the list");
        }
    }

    public void AddBefore(int value, int newValue)
    {
        if (Contains(value))
        {
            Node newNode = new Node(newValue);
            if (Head.Value == value)
            {
                newNode.next = Head;
                Head = newNode;
                if (Tail == null) Tail = newNode;
            }
            else
            {
                Node temp = Head;
                while (temp.next.Value != value)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }
        else
        {
            Console.WriteLine("Value not found in the list");
        }
    }

    public void Remove(int value)
    {
        if (Contains(value))
        {
            if (Head.Value == value)
            {
                Head = Head.next;
                if (Head == null) Tail = null;
            }
            else
            {
                Node temp = Head;
                while (temp.next.Value != value)
                {
                    temp = temp.next;
                }
                temp.next = temp.next.next;
                if (temp.next == null) Tail = temp;
            }
        }
        else
        {
            Console.WriteLine("Value not found in the list");
        }
    }

    public void Traverse()
    {
        Node node1 = Head;
        while (node1 != null)
        {
            Console.WriteLine(node1.Value);
            node1 = node1.next;
        }
        Console.WriteLine("End of list");
    }
}