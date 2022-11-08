using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] peopleCount = new int[wagons];
            int result = 0;
            for (int i = 0; i < wagons; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());
                peopleCount[i] = numberOfPeople;
                result += numberOfPeople;
            }
            Console.WriteLine(String.Join(" ", peopleCount));
            Console.WriteLine(result);
        }
    }
}
