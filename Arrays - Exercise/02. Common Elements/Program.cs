using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(" ");
            string[] secondArray = Console.ReadLine()
                .Split(" ");
            foreach (string num in secondArray)
            {
                foreach (string item in firstArray)
                {
                    if (num == item)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
        }
    }
}
