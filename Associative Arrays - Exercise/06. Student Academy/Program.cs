namespace _06._Student_Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentsInfo = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (studentsInfo.ContainsKey(studentName))
                {
                    studentsInfo[studentName].Add(studentGrade);
                    continue;
                }
                studentsInfo[studentName] = new List<double>();
                studentsInfo[studentName].Add(studentGrade);
            }
            double value = 4.50;
            foreach (var stud in studentsInfo)
            {
                if (stud.Value.Average() >= value)
                {
                    Console.WriteLine($"{stud.Key} -> {stud.Value.Average():f2}");
                }
                
            }
        }
    }
}
