﻿using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                //string -> char => Parse
                char currCh = char.Parse(Console.ReadLine());

                sum += (int)currCh;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
