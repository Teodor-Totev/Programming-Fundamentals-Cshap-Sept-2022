using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = 0;
            while(n > 0)
            {
                int currDigit = n % 10;
                result += currDigit;
                n = n / 10;
            }
            Console.WriteLine(result);
        }
    }
}
