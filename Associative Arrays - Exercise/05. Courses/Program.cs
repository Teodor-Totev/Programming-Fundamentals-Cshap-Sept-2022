namespace _05._Courses
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            var information = new Dictionary<string, List<string>>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] infoArg = command
                    .Split(" : ");
                string courseName = infoArg[0];
                string studentName = infoArg[1];

                if (!information.ContainsKey(courseName))
                {
                    information[courseName] = new List<string>();
                }
                    information[courseName].Add(studentName);
            }

            foreach (var kvp in information)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
