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
       
        private Node front;
        private Node rear;

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
        public void Enqueue(int value)
        {
            //creating the new node with given value
            Node newNode = new Node(value);
            //check whether the front is null or not . 
            if (front == null)
            {
                front = newNode;
            }
            //make ne element as head
            else
            {
                rear = front;
                while (rear.Next != null)
                {
                    rear = rear.Next;
                }
                rear.Next = newNode;
            }
        }
        public void Deque()
        {
            rear = front;
            if (rear == null)
            {
                Console.WriteLine("No element in the list");
            }
            //make the next node as head
            else
            {
                front = front.Next;
            }
            Console.WriteLine("{0} ", rear.value);
        }
        public int CheckFront()
        {
            if (front == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }
    }
}