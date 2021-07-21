using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to palindrome");
            Dequeue<char> dequeue = new Dequeue<char>();
            int palindrom = 1;
            string word = "maadam";
            for (int i = 0; i < word.Length; i++)
            {
                dequeue.AddFront(word[i]);
            }
            while (dequeue.CheckEqual() == 1)
            {
                if (!(dequeue.RemoveFront().Equals(dequeue.RemoveRear())))
                {
                    palindrom = 0;
                    break;
                }
            }
            if (palindrom == 1)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("Sriring is not palindrome");
            }
        }
    }
}

