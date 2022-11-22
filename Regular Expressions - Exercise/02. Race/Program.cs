using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> nameAndDistance = new Dictionary<string, int>();
            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string name = GetParticipiantsName(input);
                int distance = GetParticipiantsDistance(input);
                if (!participants.Contains(name))
                {
                    continue;
                }
                else if (participants.Contains(name))
                {
                    if (nameAndDistance.ContainsKey(name))
                    {
                        nameAndDistance[name] += distance;
                    }
                    else
                    {
                        nameAndDistance[name] = distance;
                    }
                }
            }

            var sortedDict = nameAndDistance
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            List<string> orderedList = new List<string>();

            foreach (var kvp in sortedDict)
            {
                orderedList.Add(kvp.Key);
            }
            Console.WriteLine($"1st place: {orderedList[0]}");
            Console.WriteLine($"2nd place: {orderedList[1]}");
            Console.WriteLine($"3rd place: {orderedList[2]}");

        }
        static string GetParticipiantsName(string input)
        {
            string name = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];

                if (char.IsLetter(currCh))
                {
                    name += currCh;
                }
            }

            return name;
        }
        static int GetParticipiantsDistance(string input)
        {
            int distance = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];

                if (char.IsDigit(currCh))
                {
                    distance += currCh - '0';
                }
            }
            return distance;
        }
    }
}
