using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLibrary
{
    public class IntList
    {
        Node Head;
        Node Tail;
        public int Count { get; private set; }
        public IntList()
        {
            Head = new Node();
            Tail = Head;
            Count = 0;
        }
        private Node GetNode(int index)
        {
            Node go = Head;
            for (int i = 0; i <= index; i++)
            {
                go = go.Next;
            }
            return go;
        }
        public void Add(int value)
        {
            Count++;
            Tail.Next = new Node(value);
            Tail = Tail.Next;
        }
        public void Insert(int value, int index)
        {
            if (index < 0 && index > Count)
                throw new IndexOutOfRangeException();
            if(index == Count)
            {
                Add(value);
                return;
            }
            Node prev = GetNode(index - 1);
            prev.Next = new Node(value, prev.Next);
            Count++;
        }
        public void Remove(int index)
        {

            if (index < 0 && index >= Count)
                throw new IndexOutOfRangeException();
            Node prev = GetNode(index - 1);
            if (index == Count - 1)
            {
                Tail = prev;
            }
            prev.Next = prev.Next.Next;
            Count--;
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();
                return GetNode(index).Value;
            }
            set
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();
                GetNode(index).Value = value;

            }
        }
        public int GetCountWithValue(int value) => Head.Next.GetCountWithValue(value);

    }
}
