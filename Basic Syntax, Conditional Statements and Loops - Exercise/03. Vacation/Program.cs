using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double studPrice = 0;
            double busPrice = 0;
            double regPrice = 0;
            if (dayOfWeek == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    studPrice = countOfPeople * 8.45;
                    if (countOfPeople >= 30)
                    {
                        studPrice -= studPrice * 0.15;
                    }
                    Console.WriteLine($"Total price: {studPrice:f2}");
                }
                else if (typeOfGroup == "Business")
                {
                    busPrice = countOfPeople * 10.90;
                    if (countOfPeople >= 100)
                    {
                        busPrice -= 109;
                    }
                    Console.WriteLine($"Total price: {busPrice:f2}");
                }
                else
                {
                    regPrice = countOfPeople * 15;
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        regPrice -= regPrice * 0.05; 
                    }
                    Console.WriteLine($"Total price: {regPrice:f2}");
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    studPrice = countOfPeople * 9.80;
                    if (countOfPeople >= 30)
                    {
                        studPrice -= studPrice * 0.15;
                    }
                    Console.WriteLine($"Total price: {studPrice:f2}");
                }
                else if (typeOfGroup == "Business")
                {
                    busPrice = countOfPeople * 15.60;
                    if (countOfPeople >= 100)
                    {
                        busPrice -= 156;
                    }
                    Console.WriteLine($"Total price: {busPrice:f2}");
                }
                else
                {
                    regPrice = countOfPeople * 20;
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        regPrice -= regPrice * 0.05;
                    }
                    Console.WriteLine($"Total price: {regPrice:f2}");
                }
            }
            else
            {
                if (typeOfGroup == "Students")
                {
                    studPrice = countOfPeople * 10.46;
                    if (countOfPeople >= 30)
                    {
                        studPrice -= studPrice * 0.15;
                    }
                    Console.WriteLine($"Total price: {studPrice:f2}");
                }
                else if (typeOfGroup == "Business")
                {
                    busPrice = countOfPeople * 16;
                    if (countOfPeople >= 100)
                    {
                        busPrice -= 160;
                    }
                    Console.WriteLine($"Total price: {busPrice:f2}");
                }
                else
                {
                    regPrice = countOfPeople * 22.50;
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        regPrice -= regPrice * 0.05;
                    }
                    Console.WriteLine($"Total price: {regPrice:f2}");
                }
            }
        }
    }
}
