using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrutures.StackDS
{
    public class StackDS
    {
        Node top;
        public StackDS()
        {
            top = null;
        }
        public bool isEmpty()
        {
            if (top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void push(int item)
        {
            if (isEmpty())
            {
                Node newnode = new Node(item);
                newnode.Next = null;
                top = newnode;

            }
            else
            {
                Node newnod = new Node(item);
                newnod.Next = top;
                top = newnod;
            }
        }

       
public int pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                int value = top.Data; // store the data of the top node to return it later
                top = top.Next;// move the top to the next node
                return value;// return the value of the popped node
            }
        }
 

        public int peek()
        {
            return top.Data;


        }

        public void display()
        {
            Node current = top;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }

        }
        public int count()
        {
            Node current = top;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;

        }
    }
}
