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
                string requestedPassword = cmdArg[1];

                contestsAndPasswords[contest] = requestedPassword;
            }
            //var users = new Dictionary<string, int>();
            var allUsers = new Dictionary<string, Dictionary<string, int>>();
            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] cmdArg = command
                    .Split("=>");
                string contest = cmdArg[0];
                string requestedPassword = cmdArg[1];
                string userName = cmdArg[2];
                int points = int.Parse(cmdArg[3]);

                if (contestsAndPasswords.ContainsKey(contest) &&
                    contestsAndPasswords[contest] == requestedPassword)
                {
                    if (allUsers.ContainsKey(contest) &&
                        allUsers[contest].ContainsKey(userName) &&
                        allUsers[contest][userName] < points)
                    {
                        //users[userName] = points;
                        allUsers[contest][userName] = points;
                        continue;
                    }
                    //users[userName] = points;
                    allUsers[contest] = new Dictionary<string, int>();
                    allUsers[contest][userName] = points;
                }
            }
        }
    }
}
