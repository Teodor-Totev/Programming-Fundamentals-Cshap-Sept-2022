namespace _02._Articles
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Arcticle> arcticles = new List<Arcticle>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] arcticleArg = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = arcticleArg[0];
                string content = arcticleArg[1];
                string author = arcticleArg[2];

                Arcticle currArcticle = new Arcticle(title, content, author);
                arcticles.Add(currArcticle);
            }

            foreach (Arcticle arcticle in arcticles)
            {
                Console.WriteLine(arcticle.ToString());
            }
        }
    }

    public class Arcticle
    {
        public Arcticle(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
