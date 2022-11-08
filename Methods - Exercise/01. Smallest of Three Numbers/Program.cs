using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int smallestNum = GetSmallestNum(num1, num2, num3);
            Console.WriteLine(smallestNum);
        }

        static int GetSmallestNum (int num1, int num2, int num3)
        {
            int smallestNum = int.MaxValue;
            if (num1 < smallestNum)
            {
                smallestNum = num1;
            }
            if (num2 < num1)
            {
                smallestNum = num2;
            }
            if(num3 < num2 && num3 < num1)
            {
                smallestNum = num3;
            }
            return smallestNum;
        }
    }
}
