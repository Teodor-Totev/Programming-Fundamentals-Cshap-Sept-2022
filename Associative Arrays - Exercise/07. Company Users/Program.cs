namespace _07._Company_Users
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            var companiesInfo = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command
                    .Split(" -> ");
                string companyName = cmdArg[0];
                string employeeId = cmdArg[1];

                if (companiesInfo.ContainsKey(companyName))
                {
                    if (companiesInfo[companyName].Contains(employeeId))
                    {
                        continue;
                    }
                    companiesInfo[companyName].Add(employeeId);
                    continue;
                }

                companiesInfo[companyName] = new List<string>();
                companiesInfo[companyName].Add(employeeId);
            }
            foreach (var kvp in companiesInfo)
            {
                Console.WriteLine(kvp.Key);
                foreach (var employeeId in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
