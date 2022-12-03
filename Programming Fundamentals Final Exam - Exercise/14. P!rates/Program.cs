using System;
using System.Collections.Generic;

namespace _14._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();

            string firstCommand;
            while ((firstCommand = Console.ReadLine()) != "Sail")
            {
                string[] cmdArgs = firstCommand.Split("||");

                string town = cmdArgs[0];
                int population = int.Parse(cmdArgs[1]);
                int gold = int.Parse(cmdArgs[2]);

                if (!cities.ContainsKey(town))
                {
                    cities[town] = new City(population, gold);
                }
                else
                {
                    cities[town].Population += population;
                    cities[town].Gold += gold;
                }

            }

            string secondCommnad;
            while((secondCommnad = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = secondCommnad.Split("=>");
                string cmdType = cmdArgs[0];
                string town = cmdArgs[1];
                

                if (cmdType == "Plunder")
                {
                    int people = int.Parse(cmdArgs[2]);
                    int gold = int.Parse(cmdArgs[3]);

                    cities[town].Population -= people;
                    cities[town].Gold -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (cities[town].Population <= 0 || cities[town].Gold <= 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (cmdType == "Prosper")
                {
                    int gold = int.Parse(cmdArgs[2]);

                    if (gold <= 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        cities[town].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
                    }
                }
            }

            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var town in cities)
                {
                    //{town1} -> Population: {people} citizens, Gold: {gold} kg

                    Console.WriteLine($"{town.Key} -> Population: {town.Value.Population} citizens, Gold: {town.Value.Gold} kg");
                }
            }
        }
    }
    public class City
    {
        public City(int population, int gold)
        {
            this.Population = population;
            this.Gold = gold;
        }

        public int Population { get; set; }

        public int Gold { get; set; }
    }
}
