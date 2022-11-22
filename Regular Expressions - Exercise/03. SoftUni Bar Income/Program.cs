using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z]{1}[a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";

            decimal income = 0m;
            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match inputInfo = Regex.Match(input , pattern);

                if (inputInfo.Success)
                {
                    string customerName = inputInfo.Groups["name"].Value;
                    string product = inputInfo.Groups["product"].Value;
                    int count = int.Parse(inputInfo.Groups["count"].Value);
                    decimal price = decimal.Parse(inputInfo.Groups["price"].Value);

                    decimal totalPrice = count * price;
                    income += totalPrice;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
