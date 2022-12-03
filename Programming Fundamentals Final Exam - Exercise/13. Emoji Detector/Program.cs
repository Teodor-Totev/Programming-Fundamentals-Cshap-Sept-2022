using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _13._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(::|\*\*)(?<emoji>[A-Z]{1}[a-z]{2,})\1";
            string pattern2 = @"(?<digits>[0-9])";

            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);
            MatchCollection coolTreshold = Regex.Matches(text, pattern2);

            BigInteger coolThresholdSum = 1;
            foreach (Match digit in coolTreshold)
            {
                int currDigitInText = int.Parse(digit.Groups["digits"].Value);
                coolThresholdSum *= currDigitInText;
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (Match match in matches)
            {
                string emoji = match.Groups["emoji"].Value;
                long emojiCoolness = GetEmojiCoolness(emoji);

                if (emojiCoolness >= coolThresholdSum)
                {
                    Console.WriteLine(match);
                }


            }
        }
        static long GetEmojiCoolness(string emoji)
        {
            long emojiCoolness = 0;
            foreach (var letter in emoji)
            {
                emojiCoolness += (int)letter;
            }
            return emojiCoolness;
        }
    }
}
