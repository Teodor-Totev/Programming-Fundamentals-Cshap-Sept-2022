namespace _01._Secret_Chat
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArg = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string commandType = cmdArg[0];

                if (commandType == "InsertSpace")
                {
                    int index = int.Parse(cmdArg[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (commandType == "Reverse")
                {
                    string substring = cmdArg[1];

                    int startIndex = message.IndexOf(substring);

                    if (message.Contains(substring))
                    {
                        message = message.Remove(startIndex, substring.Length);
                        message += string.Join("", substring.Reverse());
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandType == "ChangeAll")
                {
                    string substring = cmdArg[1];
                    string replacement = cmdArg[2];

                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
