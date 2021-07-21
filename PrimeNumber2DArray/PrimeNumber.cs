using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber2DArray
{
    class PrimeNumber
    {
        int row = 10;
        int anagramCount = 0;
        int[] array = new int[1000];
        int[,] primeArray = new int[10, 100];
        int[] prime = new int[10];
        PrimeLinkedList anagram = new PrimeLinkedList();
        PrimeLinkedList anagramQueue = new PrimeLinkedList();
        public bool IsPrime(int value)
        {
            bool PRIME = true;
            for (int i = 2; i < Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                {
                    PRIME = false;
                }
            }
            return PRIME;
        }
        public static bool isAnagram(String str1, String str2)
        {
            bool flag = true;
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            if (str1.Length != str2.Length)
            {
                return false;
            }
            else
            {
                Array.Sort(arr1);
                Array.Sort(arr2);
                for (int i = 0; i < str1.Length; i++)
                {
                    if (arr1[i].CompareTo(arr2[i]) != 0)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            return flag;
        }

        public void StoreAnagaram()
        {
            for (int i = 0; i < anagramCount; i++)
            {
                for (int j = 0; j < anagramCount; j++)
                {
                    if (array[i] == array[j])
                    {
                        continue;
                    }
                    if (isAnagram(array[i].ToString(), array[j].ToString()))
                    {
                        anagram.Push(array[i]);
                        anagramQueue.Enqueue(array[i]);
                        break;
                    }
                }

            }
        }
        public void StorePrime()
        {
            int num = 2;
            int j1 = 0;
            for (int i = 0; i < row; i++)
            {
                j1 = 0;
                for (int j = 0; j < 100; j++)
                {
                    if (IsPrime(num))
                    {
                        primeArray[i, j1] = num;
                        array[anagramCount] = num;
                        j1++;
                        anagramCount++;
                    }
                    num = num + 1;
                }
                prime[i] = j1;
            }
        }
        public void Print()
        {
            for (int i = 0; i < primeArray.GetLength(0); i++)
            {
                for (int j = 0; j < prime[i]; j++)
                {

                    Console.Write("{0} ", primeArray[i, j]);

                }
                Console.WriteLine();
            }

        }

        public void PrintAnagram()
        {
            while (anagram.CheckTop() == 0)
            {
                anagram.pop();
            }
        }
        public void PrintAnagramQueue()
        {
            while (anagramQueue.CheckFront() == 1)
            {
                anagramQueue.Deque();
            }
        }
    }
}
