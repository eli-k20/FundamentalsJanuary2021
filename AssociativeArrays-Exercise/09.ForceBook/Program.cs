using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> membersBySides = new Dictionary<string, List<string>>();

            Dictionary<string, string> members = new Dictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Lumpawaroo")
                {
                    break;
                }

                if (line.Contains(" | "))
                {
                    string[] parts = line.Split(" | ");

                    string forceSide = parts[0];
                    string forceUser = parts[1];

                    if (members.ContainsKey(forceUser))
                    {
                        continue;
                    }

                    if (!membersBySides.ContainsKey(forceSide))
                    {
                        membersBySides.Add(forceSide, new List<string>());
                    }

                    membersBySides[forceSide].Add(forceUser);
                    members.Add(forceUser, forceSide);
                }
                else
                {
                    string[] parts = line.Split(" -> ");

                    string forceUser = parts[0];
                    string forceSide = parts[1];

                    if (!membersBySides.ContainsKey(forceSide))
                    {
                        membersBySides.Add(forceSide, new List<string>());
                    }

                    if (members.ContainsKey(forceUser))
                    {
                        string oldSide = members[forceUser];

                        membersBySides[oldSide].Remove(forceUser);
                        membersBySides[forceSide].Add(forceUser);
                        members[forceUser] = forceSide;
                    }

                    else
                    {
                        membersBySides[forceSide].Add(forceUser);
                        members.Add(forceUser, forceSide);
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            Dictionary<string, List<string>> result = membersBySides
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in result)
            {
                Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");

                pair.Value.Sort();

                foreach (var user in pair.Value)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
