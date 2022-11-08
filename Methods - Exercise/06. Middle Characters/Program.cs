using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleCharacters(text);
        }
        static void PrintMiddleCharacters(string text)
        {
            //int len = text.Length;
            
            if (text.Length % 2 != 0)
            {
                Console.WriteLine(text[text.Length / 2]);
            }
            else
            {
                Console.WriteLine(text.Substring((text.Length / 2) - 1, 2));
            }
        }
    }
}
