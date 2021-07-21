using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class DequeueNode<T>
    {
        public T value;
        public DequeueNode<T> prev;
        public DequeueNode<T> next;
        public DequeueNode(T value)
        {
            this.value = value;
            this.next = null;
            this.prev = null;
        }
    }
    class Dequeue<T>
    {
        DequeueNode<T> front;
        DequeueNode<T> rear;

        public void AddFront(T value)
        {
            DequeueNode<T> newNode = new DequeueNode<T>(value);
            if (front == null && rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                newNode.next = front;
                front.prev = newNode;
                front = newNode;
            }
        }

        public T RemoveFront()
        {
            T value;
            if (front == null)
            {
                return default;
            }
            else
            {
                value = front.value;
                front = front.next;
                front.prev = null;
            }
            return value;
        }
        public T RemoveRear()
        {
            T value;
            if (rear == null)
            {
                return default;
            }
            else
            {
                value = rear.value;
                if (rear.prev == null)
                {
                    rear = null;
                }
                else
                {
                    rear = rear.prev;
                    rear.next = null;
                }
            }
            return value;
        }

        public int CheckEqual()
        {
            if (front == rear)
            {
                return 0;
            }
            if (front == null || rear == null)
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
