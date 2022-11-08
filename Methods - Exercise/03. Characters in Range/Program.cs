using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char start2 = start;
            if (end < start)
            {
                start = end;
                end = start2;
            }
            GetCharactersInRange(start, end);
        }
        static void GetCharactersInRange(char start, char end)
        {
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
