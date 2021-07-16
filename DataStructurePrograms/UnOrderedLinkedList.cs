using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
   
        public class Node<T>
        {
            public T value;
            public Node<T> Next;
            public Node(T value)
            {
                this.value = value;
                this.Next = null;
            }
        }
        public class UnOrderedLinkedList<T>
        {
            private Node<T> head;


            public void AddLast(T value)
            {
                //creating the new node with given value
                Node<T> newNode = new Node<T>(value);
                //check whether the head is null or not . 
                if (head == null)
                {
                    head = newNode;
                }
                //iterate till the last element and make next feild of last element as newNode
                else
                {
                    Node<T> temp = head;
                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = newNode;
                }
            }


            public void DeleteNode(T value)
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
                    Node<T> prev = head;
                    Node<T> temp = head;

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
            //method to search for the element
            public int SearchNode(T value)
            {
                if (head == null)
                {
                    return 0;
                }
                else
                {
                    Node<T> temp = head;
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

            public int SizeOf()
            {
                if (head == null)
                {
                    return 0;
                }
                else
                {
                    Node<T> temp = head;
                    int count = 0;
                    while (temp != null)
                    {
                        count++;
                        temp = temp.Next;
                    }
                    return count;
                }
            }
            //method to display the element 
            public string DisplayList()
            {
                Node<T> temp = head;
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
                    data = data + temp.value;
                }

                return data;
            }
        }
    }

