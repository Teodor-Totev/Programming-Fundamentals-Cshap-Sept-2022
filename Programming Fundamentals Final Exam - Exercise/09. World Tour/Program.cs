using System;
using System.Text;

namespace _09._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] cmdArg = command.Split(':');
                string cmdType = cmdArg[0];
                if (cmdType == "Add Stop")
                {
                    int index = int.Parse(cmdArg[1]);
                    string substring = cmdArg[2];
                    if (stops.Length - 1 >= index)
                    {
                        stops = stops.Insert(index, substring);
                    }
                }
                else if (cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
                    if (stops.Length - 1 >= startIndex && stops.Length - 1 >= endIndex)
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                }
                else if (cmdType == "Switch")
                {
                    string oldString = cmdArg[1];
                    string newString = cmdArg[2];
                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                    }
                }
                Console.WriteLine(stops);
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
