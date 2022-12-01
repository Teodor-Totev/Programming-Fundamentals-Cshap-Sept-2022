using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plants = new Dictionary<string, int>();
            Dictionary<string, List<double>> ratingList = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] plantsInfo = Console.ReadLine()
                    .Split("<->");
                string plant = plantsInfo[0];
                int rarity = int.Parse(plantsInfo[1]);

                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, rarity);
                    ratingList.Add(plant, new List<double>());
                }
                else
                {
                    plants[plant] = rarity;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArgs = command.Split(':');
                string commandType = cmdArgs[0];

                string[] subString = cmdArgs[1].Trim().Split('-', StringSplitOptions.RemoveEmptyEntries);

                string plant = subString[0].Trim();

                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (commandType == "Rate")
                {
                    double rating = double.Parse(subString[1].Trim());
                    ratingList[plant].Add(rating);
                }
                else if (commandType == "Update")
                {
                    int newRariry = int.Parse(subString[1].Trim());
                    plants[plant] = newRariry;
                }
                else if (commandType == "Reset")
                {
                    ratingList[plant].Clear();
                }

            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                string plantName = plant.Key;
                int rarity = plant.Value;
                double averageRate;
                if (ratingList[plantName].Sum() == 0)
                {
                    averageRate = 0;
                }
                else
                {
                    averageRate = ratingList[plantName].Average();
                }
                Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {averageRate:f2}");
            }
        }
    }
}
