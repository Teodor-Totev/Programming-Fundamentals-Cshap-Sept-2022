namespace P01._Ranking
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            var contestsAndPasswords = new Dictionary<string, string>();

            string command;
            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] cmdArg = command
                    .Split(":");
                string contest = cmdArg[0];
                string password = cmdArg[1];

                contestsAndPasswords[contest] = password;
            }

            var users = new SortedDictionary<string, Dictionary<string, int>>();

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] cmdArg = command
                    .Split("=>");
                string contest = cmdArg[0];
                string password = cmdArg[1];
                string userName = cmdArg[2];
                int points = int.Parse(cmdArg[3]);

                if (contestsAndPasswords.ContainsKey(contest) &&
                    contestsAndPasswords[contest] == password)
                {
                    if (!users.ContainsKey(userName))
                    {
                        users[userName] = new Dictionary<string, int>();
                        users[userName][contest] = points;
                    }
                    else
                    {
                        if (!users[userName].ContainsKey(contest))
                        {
                            users[userName][contest] = points;
                        }
                        else
                        {
                            if (users[userName][contest] < points)
                            {
                                users[userName][contest] = points;
                            }
                        }
                    }
                }
            }

            Dictionary<string, int> usersTotalPoints = new Dictionary<string, int>();

            foreach (var kvp in users)
            {
                usersTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }
            int maxPoints = usersTotalPoints
                .Values
                .Max();

            foreach (var kvp in usersTotalPoints)
            {
                if (kvp.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                }
            }

            Console.WriteLine("Ranking:");

            foreach (var user in users)
            {
                Console.WriteLine(user.Key);

                foreach (var kvp in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                    
                }
            }
        }
    }
}
