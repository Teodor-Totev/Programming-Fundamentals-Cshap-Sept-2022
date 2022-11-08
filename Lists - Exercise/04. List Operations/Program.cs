using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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
            while((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string commandType = cmdArgs[0];

                if(commandType == "Add")
                {
                    int numToAdd = int.Parse(cmdArgs[1]);
                    numbers.Add(numToAdd);
                }
                else if (commandType == "Insert")
                {
                    int numToInsert = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, numToInsert);
                }
                else if (commandType == "Remove")
                {
                    int removeIndex = int.Parse(cmdArgs[1]);
                    if (IsIndexInvalid(numbers, removeIndex))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(removeIndex);
                }
                else if (commandType == "Shift")
                {
                    string direction = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);
                    if(direction == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                    else if(direction == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                }

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
        static bool IsIndexInvalid(List<int> numbers, int index)
            => index < 0 || index >= numbers.Count;

        static void ShiftRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int currNum = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, currNum);
            }
        }
        static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int currNum = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(currNum);

            }
        }
    }
}
