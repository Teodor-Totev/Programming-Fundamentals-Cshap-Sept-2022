using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(\||#){1}(?<itemName>[A-Za-z]+( [A-Za-z]+)*)\1(?<date>\d{2}/\d{2}/\d{2})\1(?<calories>\d+)\1");

            string text = Console.ReadLine();

            MatchCollection matches = pattern.Matches(text);

            int totalCalories = 0;
            foreach (Match item in matches)
            {
                int calories = int.Parse(item.Groups["calories"].Value);
                totalCalories += calories;
            }
            int days = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match foodItem in matches)
            {
                string name = foodItem.Groups["itemName"].Value;
                string date = foodItem.Groups["date"].Value;
                string calories = foodItem.Groups["calories"].Value;

                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}
