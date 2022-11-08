using System;
using System.Linq;
namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split(" ");
            //.Select(int.Parse)
            //.ToArray();


            string numb = string.Empty;
            int counter = 0;
            int maxCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                string currNum = numbers[i];
                for (int r = i + 1; r < numbers.Length; r++)
                {
                    string nextNum = numbers[r];
                    if (currNum == nextNum)
                    {
                        counter++;
                        if(counter > maxCount)
                        {
                            maxCount = counter;
                            numb = numbers[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                counter = 0;
            }
            for (int i = 0; i <= maxCount; i++)
            {
                Console.Write(numb + " ");
            }
        }
    }
}

