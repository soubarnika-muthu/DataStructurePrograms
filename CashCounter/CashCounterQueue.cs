using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    public class QueueNode<T>
    {
        public T value;
        public QueueNode<T> Next;
        public QueueNode(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }

    //queue to perform operations of cash counter
    class CashCounterQueue<T>
    {
        private QueueNode<T> front;
        private QueueNode<T> rear;
       
        //method to insert the element in front;
        public void AddFirst(T value)
        {
            //creating the new node with given value
            QueueNode<T> newNode = new QueueNode<T>(value);
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
        public string DeleteFirst()
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
            return rear.value.ToString();
        }
        public void DisplayList()
        {
            rear = front;
            //if head is null then no element is present
            if (front == null)
            {
                Console.WriteLine("No element in the list");
            }
            //else until temp become null print the elements 
            else
            {
                while (rear != null)
                {
                    Console.WriteLine("" + rear.value);
                    rear = rear.Next;
                }
            }
        }
    }
}
