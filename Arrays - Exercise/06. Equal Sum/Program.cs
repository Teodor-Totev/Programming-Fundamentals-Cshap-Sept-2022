using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool isHaveIndex = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int r = i + 1; r < numbers.Length; r++)
                {
                    int rightNum = numbers[r];
                    rightSum += rightNum;
                }
                for (int l = 0; l < i; l++)
                {
                    int leftNum = numbers[l];
                    leftSum += leftNum;
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    isHaveIndex = true;
                }
                if (isHaveIndex)
                {
                    break;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (isHaveIndex == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
