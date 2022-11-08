using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelsCount = GetVowelsCount(text);
            Console.WriteLine(vowelsCount);
        }

        static int GetVowelsCount(string text)
        {
            int vowelsCount = 0;
            char[] vawels = new char[] { 'a', 'e', 'o', 'u', 'i' };
            foreach (char letter in text.ToLower())
            {
                if (vawels.Contains(letter))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
