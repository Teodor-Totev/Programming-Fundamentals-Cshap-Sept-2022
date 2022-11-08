using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < n.Length; i++)
            {
                int currNum = n[i];
                bool isTopInteger = true;
                for (int j = i + 1; j < n.Length; j++)
                {
                    int nextNumber = n[j];
                    if (nextNumber >= currNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}
