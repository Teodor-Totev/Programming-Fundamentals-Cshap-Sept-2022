using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string input;

            while((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input
                    .Split(" ");
                string commandType = inputArgs[0];
                
                if(commandType == "Add")
                {
                    int passengers = int.Parse(inputArgs[1]);
                    wagons.Add(passengers);
                    continue;
                }
                int incomingPassengers = int.Parse(inputArgs[0]);
                for (int i = 0; i < wagons.Count; i++)
                {
                    int passengersInCurrWagon = wagons[i];
                    if(incomingPassengers + passengersInCurrWagon <= maxCapacity)
                    {
                        wagons[i] = incomingPassengers + passengersInCurrWagon;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
