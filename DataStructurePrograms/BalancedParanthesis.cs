using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class Balancedparanthesis
    {
        public class StackNode<T>
        {
            public T value;
            public StackNode<T> Next;
            public StackNode(T value)
            {
                this.value = value;
                this.Next = null;
            }
        }

        public class Stack<T>
        {
            public StackNode<T> top;

            public void Push(T value)
            {
                StackNode<T> newNode = new StackNode<T>(value);
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

            public int pop()
            {
                if (top == null)
                {
                    Console.WriteLine("Unbalanced");
                    return 0;

                }
                else
                {
                    top = top.Next;
                    return 1;
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
        public void CheckParanthesis()
        {
            int unbalanced = 0;
            Stack<char> stack = new Stack<char>();
            string exp = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i].Equals('('))
                {
                    stack.Push(exp[i]);
                }
                else if (exp[i].Equals(')'))
                {
                    unbalanced = stack.pop();
                    if (unbalanced == 1)
                    {
                        break;
                    }
                }
            }
            if (stack.CheckTop() == 1)
            {
                Console.WriteLine("Equation is balanced");
            }
            else if (stack.CheckTop() == 0 && unbalanced == 0)
            {
                Console.WriteLine("Equation is unbalanced");
            }
        }
    }
}

