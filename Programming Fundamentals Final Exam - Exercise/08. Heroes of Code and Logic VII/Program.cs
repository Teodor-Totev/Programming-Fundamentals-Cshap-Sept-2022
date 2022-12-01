using System;
using System.Collections.Generic;

namespace _08._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string hero = Console.ReadLine();
                string[] heroInfo = hero.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = heroInfo[0];
                int healthPoints = int.Parse(heroInfo[1]);
                int manaPoints = int.Parse(heroInfo[2]);

                heroes[name] = new Hero(name, healthPoints, manaPoints);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                string heroName = cmdArgs[1];

                if (cmdType == "CastSpell")
                {
                    int manaPointsNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    if (heroes[heroName].ManaPoints >= manaPointsNeeded)
                    {
                        heroes[heroName].ManaPoints -= manaPointsNeeded;
                        int manaPointsLeft = heroes[heroName].ManaPoints;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {manaPointsLeft} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmdType == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];
                    heroes[heroName].HealthPoints -= damage;
                    int hpLeft = heroes[heroName].HealthPoints;
                    if (heroes[heroName].HealthPoints > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {hpLeft} HP left!");
                    }
                    else
                    {
                        heroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (cmdType == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);

                    if (heroes[heroName].ManaPoints + amount <= 200)
                    {
                        heroes[heroName].ManaPoints += amount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        continue;
                    }
                    else
                    {
                        int recovered = 200 - heroes[heroName].ManaPoints;
                        Console.WriteLine($"{heroName} recharged for {recovered} MP!");
                        heroes[heroName].ManaPoints = 200;
                    }
                }
                else if (cmdType == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    
                    if (heroes[heroName].HealthPoints + amount <= 100)
                    {
                        heroes[heroName].HealthPoints += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                        continue;
                    }
                    else
                    {
                        int recovered = 100 - heroes[heroName].HealthPoints;
                        Console.WriteLine($"{heroName} healed for {recovered} HP!");
                        heroes[heroName].HealthPoints = 100;
                    }
                }
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.HealthPoints}");
                Console.WriteLine($"  MP: {hero.Value.ManaPoints}");
            }
        }
    }
    public class Hero
    {
        public Hero(string name, int healthPoints, int manaPoints)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
        }
        public string Name { get; set; }

        public int HealthPoints { get; set; }

        public int ManaPoints { get; set; }
    }
}
