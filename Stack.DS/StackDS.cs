
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
            int value = top.Data;
            Node delptr = top;
            value = top.Data;
            top = top.Next;

            return value;
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
        public int Count()
        {
            int count = 0;
            Node current = top;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

    }

}
