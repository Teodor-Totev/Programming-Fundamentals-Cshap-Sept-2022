using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggestKegVolume = 0;
            string biggestKegModel = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentVolume = Math.PI * radius * radius * height;
                if (currentVolume > biggestKegVolume)
                {
                    biggestKegVolume = currentVolume;
                    biggestKegModel = model;
                }
            }
            Console.WriteLine($"{biggestKegModel}");
        }
    }
}
