namespace _02._Mirror_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(#|@)(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            List<string> mirrorWords = new List<string>();

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["firstWord"].Value;
                string secondWord = match.Groups["secondWord"].Value;

                string secondWordReversed = string.Join("", secondWord.Reverse());
                if(firstWord == secondWordReversed)
                {
                    string wordToAdd = $"{firstWord} <=> {secondWord}";
                    mirrorWords.Add(wordToAdd);
                }

            }
            if(mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }
    }
}
