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
        int row1 = 0, col1 = 0;
        int anagramCount = 0;
        int[] array = new int[1000];
        int[,] primeArray = new int[10, 100];
        int[,] anagram = new int[10, 100];
        int[] primeAnnagram = new int[10];
        int[] prime = new int[10];
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
            int digit = 100;
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
                        anagram[row1, col1] = array[i];
                        col1++;
                        break;
                    }
                }
                if (array[i + 1] > digit)
                {
                    primeAnnagram[row1] = col1;
                    col1 = 0;
                    row1++;
                    digit = digit + 100;
                }
            }
            primeAnnagram[row1] = col1;
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
            for (int i = 0; i < row1 + 1; i++)
            {
                for (int j = 0; j < primeAnnagram[i]; j++)
                {

                    Console.Write("{0} ", anagram[i, j]);

                }
                Console.WriteLine();
            }

        }
    }
}
