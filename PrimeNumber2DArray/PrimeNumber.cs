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
        int end = 100;
        int[,] primeArray = new int[10, 100];
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

        public void StorePrime()
        {
            int num = 2;
            int j1 = 0;
            for (int i = 0; i < row; i++)
            {
                j1 = 0;
                for (int j = 0; j < end; j++)
                {
                    if (IsPrime(num))
                    {
                        primeArray[i, j1] = num;
                        j1++;
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
                    //if (primeArray[i, j] != 0)
                    //{
                    Console.Write("{0} ", primeArray[i, j]);
                    //}
                }
                Console.WriteLine();
            }

        }
    }
}
