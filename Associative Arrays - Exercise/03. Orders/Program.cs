using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, List<decimal>>();
            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] cmdArg = command
                    .Split(" ");
                string productName = cmdArg[0];
                decimal price = decimal.Parse(cmdArg[1]);
                int quantity = int.Parse(cmdArg[2]);

                if (products.ContainsKey(productName))
                {
                    products[productName][1] += quantity;
                    if (products[productName][0] != price)
                    {
                        products[productName][0] = price;
                    }
                    products[productName][2] = (products[productName][1] * products[productName][0]);
                    continue;
                }

                products[productName] = new List<decimal>();
                products[productName].Add(price);
                products[productName].Add(quantity);
                products[productName].Add((products[productName][1] * products[productName][0]));

            }
            foreach (var kvp in products)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value[2]:f2}");
            }
        }
    }
}
