using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            //int firstPlayerCard = firstPlayer[0];
            //int secondPlayerCard = secondPlayer[0];
            for (int i = 0; i <= firstPlayer.Count; i++)
            {
                int firstPlayerCard = firstPlayer[0];
                for (int j = 0; j < secondPlayer.Count; j++)
                {
                    int secondPlayerCard = secondPlayer[0];
                    if (firstPlayerCard == secondPlayerCard)
                    {
                        firstPlayer.RemoveAt(0);
                        secondPlayer.RemoveAt(0);
                        break;
                    }
                    else if (firstPlayerCard > secondPlayerCard)
                    {
                        firstPlayer.Add(secondPlayerCard);
                        firstPlayer.Add(firstPlayerCard);
                        firstPlayer.RemoveAt(0);
                        secondPlayer.RemoveAt(0);
                        break;
                    }
                    else if (secondPlayerCard > firstPlayerCard)
                    {
                        secondPlayer.Add(firstPlayerCard);
                        secondPlayer.Add(secondPlayerCard);
                        secondPlayer.RemoveAt(0);
                        firstPlayer.RemoveAt(0);
                        break;
                    }
                }
                i = 0;
                if (secondPlayer.Count == 0)
                {
                    break;
                }
            }
            if (secondPlayer.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
