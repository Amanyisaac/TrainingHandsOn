using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrutures
{
    public  class Node
    {
        //contains (value,node)
        // data (value stored)
        public int Value { get; set; } //data
        public Node next { get; set; } // (pointer) next node (data type node the same thig refer to  )
        public Node(int value)
        {
            Value = value;
            next = null;
        }
    }
}
