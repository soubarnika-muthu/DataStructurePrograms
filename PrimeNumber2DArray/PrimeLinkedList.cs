using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber2DArray
{
    public class Node
    {
        public int value;
        public Node Next;
        public Node(int value)
        {
            this.value = value;
            this.Next = null;
        }
    }
    class PrimeLinkedList
    {
        private Node top;

        public void Push(int value)
        {
            Node newNode = new Node(value);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
        }

        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("No element");

            }
            else
            {
                Console.WriteLine("{0}", top.value);
                top = top.Next;
            }
        }
        public int CheckTop()
        {
            if (top == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}