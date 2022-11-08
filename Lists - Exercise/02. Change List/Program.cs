using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArgs[0];

                if(name == "Delete")
                {
                    int numberToRemove = int.Parse(cmdArgs[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currNum = numbers[i];
                        if(currNum == numberToRemove)
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                }
                else if (name == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    int numToInsert = int.Parse(cmdArgs[1]);
                    numbers.Insert(index, numToInsert);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
