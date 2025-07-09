using System;
using DataStrutures.StackDS;

namespace StackMainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDS myStack = new StackDS();
  

            myStack.push(10);
            myStack.push(20);
            myStack.push(30);

            Console.WriteLine("Current stack:");
            myStack.display();   
 
            Console.WriteLine("Top element (peek): " + myStack.peek());

           
            Console.WriteLine("Popped element: " + myStack.pop());

            
            Console.WriteLine("Stack after pop:");
            myStack.display();
            Console.WriteLine("Number of elements in stack: " + myStack.Count());


        }
    }
}
