using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            //1 2 3 |4 5 6 |  7  8
            List<int> output = new List<int>();
            
            for (int i = input.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    string current = input[i];
                    if (int.TryParse(current[j].ToString(), out int outputNumber))
                    {
                        output.Add(outputNumber);
                    }
                }
            }
                    
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
