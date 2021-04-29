using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);

            Regex namePattern = new Regex(@"(?<name>[A-Za-z]+)");
            Regex distancePattern = new Regex(@"(?<distance>\d)");

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of race")
                {
                    break;
                }

                MatchCollection letterMatches = namePattern.Matches(line);
                MatchCollection digitsMatches = distancePattern.Matches(line);

                string name = GetName(letterMatches);
                int sum = GetSum(digitsMatches);

                if (!participants.ContainsKey(name))
                {
                    continue;
                }
                else
                {
                    participants[name] += sum;
                }
            }

            string[] winners = participants
                .OrderByDescending(x => x.Value)
                .Take(3)
                .Select(x => x.Key)
                .ToArray();

            Console.WriteLine($"1st place: {winners[0]}");
            Console.WriteLine($"2nd place: {winners[1]}");
            Console.WriteLine($"3rd place: {winners[2]}");
        }

        private static int GetSum(MatchCollection digitsMatches)
        {
            int sum = 0;

            foreach (Match match in digitsMatches)
            {
                sum += int.Parse(match.Value);
            }

            return sum;
        }

        private static string GetName(MatchCollection matches)
        {
            StringBuilder name = new StringBuilder();

            foreach (Match match in matches)
            {
                name.Append(match.Value);
            }

            return name.ToString();
        }
    }
}
