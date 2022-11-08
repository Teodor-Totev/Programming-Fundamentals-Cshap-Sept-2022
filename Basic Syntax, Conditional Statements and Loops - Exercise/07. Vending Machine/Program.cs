using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double accumMoney = 0;

            while (command != "Start")
            {
                double coins = double.Parse(command);
                if(coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    accumMoney += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                command = Console.ReadLine();
            }
            string text = Console.ReadLine();
            while (text != "End")
            {
                if (text == "Nuts")
                {
                    if (accumMoney < 2)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        accumMoney -= 2;
                        Console.WriteLine($"Purchased nuts");
                    }
                }
                else if (text == "Water")
                {
                    if (accumMoney < 0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        accumMoney -= 0.7;
                        Console.WriteLine($"Purchased water");
                    }
                }
                else if (text == "Crisps")
                {
                    if (accumMoney < 1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        accumMoney -= 1.5;
                        Console.WriteLine($"Purchased crisps");
                    }
                }
                else if (text == "Soda")
                {
                    if (accumMoney < 0.8)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        accumMoney -= 0.8;
                        Console.WriteLine($"Purchased soda");
                    }
                }
                else if (text == "Coke")
                {
                    if (accumMoney < 1)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        accumMoney -= 1;
                        Console.WriteLine($"Purchased coke");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                text = Console.ReadLine();
            }
            Console.WriteLine($"Change: {accumMoney:f2}");
        }
    }
}
