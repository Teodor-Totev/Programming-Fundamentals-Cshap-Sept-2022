using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniturе
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Z]+[a-z]*)<<(?<price>\d+(\.\d+)*)!(?<quantity>\d+)";
            decimal totalPrice = 0;
            List<string> boughtFurniture = new List<string>();

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string furnitureName = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    decimal result = price * quantity;
                    totalPrice += result;
                    boughtFurniture.Add(furnitureName);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var furnitureName in boughtFurniture)
            {
                Console.WriteLine(furnitureName);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
