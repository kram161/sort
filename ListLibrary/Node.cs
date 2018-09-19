using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLibrary
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int value = 0, Node next = null)
        {
            Value = value;
            Next = next;
        }
        public int GetCountWithValue(int value)
        {
            return (Next == null ? 0 : Next.GetCountWithValue(value)) + (value == Value ? 1 : 0);
        }
    }
}
