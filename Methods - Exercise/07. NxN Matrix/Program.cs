﻿using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintMatrix(number);
        }
        static void PrintMatrix (int number)
        {
            for (int j = 0; j < number; j++)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
