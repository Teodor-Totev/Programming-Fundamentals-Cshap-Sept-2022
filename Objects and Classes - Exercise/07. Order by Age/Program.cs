namespace _07._Order_by_Age
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg= command.Split(" ");

                string firstEl = cmdArg[0];
                string secondEl = cmdArg[1];
                int thirdEl = int.Parse(cmdArg[2]);

                Person person = new Person(firstEl, secondEl, thirdEl);
                people.Add(person);

                for (int i = 0; i < people.Count; i++)
                {
                    Person currPerson = people[i];
                    if (currPerson.Id == secondEl)
                    {
                        currPerson.Id = secondEl;
                        currPerson.Name = firstEl;
                    }
                }
            }

            people = people
                .OrderBy(p => p.Age)
                .ToList();

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
            
        }
    }

    public class Person
    {
        public Person(string firstEl, string secondEl, int thirdEl)
        {
            Name = firstEl;
            Id = secondEl;
            Age = thirdEl;
        }
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
