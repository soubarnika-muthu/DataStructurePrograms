using System;
using System.IO;
namespace DataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of Data structure Programs");
            Console.WriteLine("1.UnOrdered List\n2.Ordered List");
            Console.WriteLine("Enter choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Console.WriteLine("UnorderedList");
                    UnOrderedLinkedList<string> unOrdered = new UnOrderedLinkedList<string>();
                    string filePath = @"C:\Users\hp\source\repos\DataStructurePrograms\DataStructurePrograms\UnOrderedListFile.txt";
                    string text = File.ReadAllText(filePath);
                    string[] textArray = text.Split(" ");
                    for (int i = 0; i < textArray.Length; i++)
                    {
                        unOrdered.AddLast(textArray[i]);
                    }
                    Console.WriteLine("enter the word to be searched:");
                    string word = Console.ReadLine();
                    int found = unOrdered.SearchNode(word);
                    if (found == 1)
                    {
                        unOrdered.DeleteNode(word);
                    }
                    else
                    {
                        unOrdered.AddLast(word);
                    }
                    string newText = unOrdered.DisplayList();
                    File.WriteAllText(filePath, newText);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Ordered List");
                    SortedLinkedList<string> ordered = new SortedLinkedList<string>();
                    string filePath1 = @"C:\Users\hp\source\repos\DataStructurePrograms\DataStructurePrograms\OrderedFile.txt";
                    string text1 = File.ReadAllText(filePath1);
                    string[] textArray1 = text1.Split(" ");
                    for (int i = 0; i < textArray1.Length; i++)
                    {
                        ordered.Add(textArray1[i]);
                    }
                    Console.WriteLine("enter the word to be searched:");
                    string word1 = Console.ReadLine();
                    int found1 = ordered.SearchNode(word1);
                    if (found1 == 1)
                    {
                        ordered.Remove(word1);
                    }
                    else
                    {
                        ordered.Add(word1);
                    }
                    string newText1 = ordered.DisplayList();
                    File.WriteAllText(filePath1, newText1);
                    break;
            }
        }


    }

}

