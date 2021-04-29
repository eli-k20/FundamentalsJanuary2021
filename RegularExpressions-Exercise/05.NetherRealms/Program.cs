using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    public class Demon
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputDemons = Console.ReadLine()
                .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            Regex healthRegex = new Regex(@"[^\d+\-*\/.]");
            Regex damageRegex = new Regex(@"[+\-]*\d+\.?\d*");
            Regex delimitersRegex = new Regex(@"[*\/]");

            List<Demon> demons = new List<Demon>();

            foreach (string demon in inputDemons)
            {
                int health = healthRegex.Matches(demon)
                    .Select(x => char.Parse(x.Value))
                    .Sum(x => x);

                double damage = damageRegex.Matches(demon)
                    .Select(x => double.Parse(x.Value))
                    .Sum(x => x);

                MatchCollection delimitersMatches = delimitersRegex.Matches(demon);
                
                foreach (Match match in delimitersMatches)
                {
                    if (match.Value == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                demons.Add(new Demon
                {
                    Name = demon,
                    Health = health,
                    Damage = damage
                });

            }

            List<Demon> sorted = demons
                .OrderBy(d => d.Name)
                .ToList();

            foreach (var demon in sorted)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }
}
