using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrutures
{
    public class Node
    {
      
        public int Value { get; set; }   
        public Node next { get; set; }   
        public Node(int value)
        {
            Value = value;
            next = null;
        }
    }
}