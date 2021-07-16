using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    //Node  creation
    public class SortNode<T>
    {
        public T value;
        public SortNode<T> Next;

        public SortNode(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }
    public class SortedLinkedList<T> where T : IComparable
    {
        public SortNode<T> head;

        public void AddFirst(SortNode<T> newNode)
        {

            //check whether the head is null or not . 
            if (head == null)
            {
                head = newNode;
            }
            //make ne element as head
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }
        //method to insert newNode next to existing nod
        public void Add(T value)
        {
            SortNode<T> sortNode = new SortNode<T>(value);
            //if the list is empty then add first
            if (head == null)
            {
                AddFirst(sortNode);
            }
            //else if first element is greater than current element then push front
            else if (head.value.CompareTo(value) >= 0)
            {
                AddFirst(sortNode);
            }

            //find the position before the maximum element then push the current element at the particular position
            else
            {
                SortNode<T> temp = head;
                SortNode<T> prev = head;
                while (temp.Next != null && temp.Next.value.CompareTo(value) < 0)
                {
                    prev = temp;
                    temp = temp.Next;
                }
                if (temp.Next == null)
                {
                    temp.Next = sortNode;
                }
                else if (temp.Next.value.CompareTo(value) > 0)
                {
                    sortNode.Next = temp.Next;
                    temp.Next = sortNode;
                }
            }

        }
        public void Remove(T value)
        {
            if (head == null)
            {
                Console.WriteLine("No element to delete");
            }
            else if (head.value.Equals(value))
            {
                head = head.Next;
            }
            //iterate till the last element or till the node is found
            else
            {
                //initialize two local variable to hold the node address
                SortNode<T> prev = head;
                SortNode<T> temp = head;

                while (temp != null && !(temp.value.Equals(value)))
                {
                    prev = temp;
                    temp = temp.Next;
                }
                if (temp.value.Equals(value))
                {
                    prev.Next = temp.Next;
                    temp.Next = null;
                }

            }
        }
        public int SearchNode(T value)
        {
            if (head == null)
            {
                return 0;
            }
            else
            {
                SortNode<T> temp = head;
                while (temp.Next != null && !(temp.value.Equals(value)))
                {
                    temp = temp.Next;
                }
                if (temp.value.Equals(value))
                {
                    return 1;
                }
                return 0;
            }
        }
        public string DisplayList()
        {
            SortNode<T> temp = head;
            string data = "";
            //if head is null then no element is present
            if (head == null)
            {
                Console.WriteLine("No element in the list");
            }
            //else until temp become null print the elements 
            else
            {
                while (temp.Next != null)
                {
                    Console.WriteLine("" + temp.value);
                    data = data + temp.value + " ";
                    temp = temp.Next;
                }
                data += temp.value;
            }
            return data;
        }
    }
}
