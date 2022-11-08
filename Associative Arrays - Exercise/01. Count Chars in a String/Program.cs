namespace _01._Count_Chars_in_a_String
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            var occurrences = new Dictionary<char, int>();

            string text = Console.ReadLine();

            foreach (char ch in text)
            {
                if(ch != ' ')
                {
                    if (!occurrences.ContainsKey(ch))
                    {
                        occurrences[ch] = 0;
                    }
                    occurrences[ch]++;
                }
            }

            foreach (var kvp in occurrences)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
