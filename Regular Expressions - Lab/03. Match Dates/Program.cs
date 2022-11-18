using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>[0-9]{2})((\.|-|/))(?<month>[A-Z]+[a-z]{2})\1(?<year>[0-9]{4})";

            string dates = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection validDates = regex.Matches(dates);

            foreach (Match item in validDates)
            {
                string day = item.Groups["day"].Value;
                string month = item.Groups["month"].Value;
                string year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            }
        }
    }
}
