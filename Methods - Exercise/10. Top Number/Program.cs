using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopNumber(n);
        }
        static void TopNumber (int num)
        {
            for (int i = 1; i < num / 10; i++)
            {
                int currNum = i;
                for (int j = 0; j < 10; j++)
                {
                    int nextNum = j;
                    int sum = currNum + nextNum;
                    if (nextNum % 2 == 0 && currNum % 2 == 0)
                    {
                        continue;
                    }
                    if (sum % 8 == 0)
                    {
                        Console.WriteLine($"{currNum}{nextNum}");
                    }
                }
            }
        }
    }
}
