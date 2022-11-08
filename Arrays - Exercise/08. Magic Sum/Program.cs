using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int firstDigit = 0;
            int secondDigit = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                for (int r = i + 1; r < numbers.Length; r++)
                {
                    int nextNum = numbers[r];
                    sum = currNum + nextNum;
                    if (sum == num)
                    {
                        firstDigit = numbers[i];
                        secondDigit = numbers[r];
                        Console.WriteLine($"{firstDigit} {secondDigit}");
                    }
                }
            }
        }
    }
}
