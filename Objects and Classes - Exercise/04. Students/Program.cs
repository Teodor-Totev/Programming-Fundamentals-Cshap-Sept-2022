namespace _04._Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int countOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studArg = Console.ReadLine()
                    .Split(" ");
                string firstName = studArg[0];
                string lastName = studArg[1];
                double grade = double.Parse(studArg[2]);

                Student currStudent = new Student(firstName, lastName, grade);
                students.Add(currStudent);
            }
            students = students
                .OrderByDescending(s => s.Grade)
                .ToList();
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
}
