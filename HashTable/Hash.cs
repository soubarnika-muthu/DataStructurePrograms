using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Hash<T>
    {
        //creating linked list for each slot to avoid collision
        private readonly int listSize;
        private LinkedList<T>[] item;
        public Hash(int size)
        {
            this.listSize = size;
            this.item = new LinkedList<T>[size];
        }
        //get the slot number
        public int GetArrayPosition(T key)
        {
            int position = key.GetHashCode() % listSize;
            return (Math.Abs(position));

        }
        //if linked is created for particular slot then get the linked list
        //else create new linked list
        protected LinkedList<T> GetLinkedList(int position)
        {
            LinkedList<T> linkedList = item[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<T>();
                item[position] = linkedList;
            }
            return linkedList;
        }
        //add the node to the slot
        public void AddNode(T value)
        {
            int position = GetArrayPosition(value);
            LinkedList<T> linkedList = GetLinkedList(position);
            linkedList.AddLast(value);
        }
        //method to display element in each slot
        public string display()
        {
            string result = "";
            for (int i = 0; i < listSize; i++)
            {
                LinkedList<T> linkedList = item[i];
                if (linkedList == null)
                {
                    continue;
                }
                foreach (T list in linkedList)
                {
                    Console.WriteLine("value:{0}", list);
                    result = list.ToString() + " " + result;
                }
            }
            return result;
        }
        public int Search(T value)
        {
            int position = GetArrayPosition(value);
            LinkedList<T> linkedList = GetLinkedList(position);
            if (linkedList == null)
            {
                return 0;
            }
            else
            {
                int found = 0;
                foreach (T i in linkedList)
                {
                    if (i.Equals(value))
                    {
                        found = 1;
                    }
                }
                return found;
            }
        }
    }

}
