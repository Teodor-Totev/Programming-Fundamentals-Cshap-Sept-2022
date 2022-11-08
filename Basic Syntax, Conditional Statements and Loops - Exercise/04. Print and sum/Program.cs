using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
                result += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {result}");
        }
    }
}
