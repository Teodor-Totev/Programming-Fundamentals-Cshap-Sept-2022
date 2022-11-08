using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int divisor = int.Parse(Console.ReadLine());
            double fact = FactorialDivison(num);
            double fact2 = FactorialDivison(divisor);
            double result = fact / fact2;
            Console.WriteLine($"{result:f2}");
        }
        static double FactorialDivison(double num)
        {
            double fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
