namespace _04._SoftUni_Parking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            var register = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine()
                    .Split(' ');
                string cmdType = cmdArg[0];
                string username = cmdArg[1];

                if (cmdType == "register")
                {
                    string licensePlateNumber = cmdArg[2];

                    if (!register.ContainsKey(username))
                    {
                        register[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (cmdType == "unregister")
                {
                    if (!register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        register.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in register)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value} ");
            }
        }
    }
}
