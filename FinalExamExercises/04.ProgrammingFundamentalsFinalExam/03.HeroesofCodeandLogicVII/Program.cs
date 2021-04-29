using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesofCodeandLogicVII
{
    class HeroInfo
    {
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
    }

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, HeroInfo> heroes = new Dictionary<string, HeroInfo>();

            for (int i = 0; i < n; i++)
            {
                string[] hero = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int HP = int.Parse(hero[1]);
                int MP = int.Parse(hero[2]);

                if (HP > 100 || MP > 200)
                {
                    continue;
                }

                heroes.Add(hero[0], new HeroInfo {HitPoints = int.Parse(hero[1]), ManaPoints = int.Parse(hero[2])});
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];

                if (command == "CastSpell")
                {
                    string heroName = parts[1];
                    int MPNeeded = int.Parse(parts[2]);
                    string spellName = parts[3];

                    if (heroes[heroName].ManaPoints >= MPNeeded)
                    {
                        heroes[heroName].ManaPoints -= MPNeeded;
                        Console.WriteLine(
                            $"{heroName} has successfully cast {spellName} and now has {heroes[heroName].ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    string heroName = parts[1];
                    int damage = int.Parse(parts[2]);
                    string attacker = parts[3];

                    heroes[heroName].HitPoints -= damage;
                    if (heroes[heroName].HitPoints > 0)
                    {
                        Console.WriteLine(
                            $"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HitPoints} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                }
                else if (command == "Recharge")
                {
                    string heroName = parts[1];
                    int amount = int.Parse(parts[2]);

                    heroes[heroName].ManaPoints += amount;

                    int reminder = heroes[heroName].ManaPoints - 200;

                    if (heroes[heroName].ManaPoints > 200)
                    {
                        heroes[heroName].ManaPoints = 200;
                        amount -= reminder;
                    }

                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else
                {
                    string heroName = parts[1];
                    int amount = int.Parse(parts[2]);

                    heroes[heroName].HitPoints += amount;

                    int reminder = heroes[heroName].HitPoints - 100;

                    if (heroes[heroName].HitPoints > 100)
                    {
                        heroes[heroName].HitPoints = 100;
                        amount -= reminder;
                    }

                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }
            }

            heroes = heroes
                .OrderByDescending(x => x.Value.HitPoints)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in heroes)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine($"  HP: {kvp.Value.HitPoints}");
                Console.WriteLine($"  MP: {kvp.Value.ManaPoints}");
            }
        }
    }
}
