using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _10._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)(?<destinations>[A-Z]{1}[A-Za-z]{2,})\1";

            string input = Console.ReadLine();

            MatchCollection destinations = Regex.Matches(input, pattern);

            List<string> output = new List<string>();
            int travelPoints = 0;

            foreach (Match match in destinations)
            {
                string destination = match.Groups["destinations"].Value;
                travelPoints += destination.Length;
                output.Add(destination);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", output)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
