using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            Regex pattern = new Regex(@"(=|\/)(?<name>[A-Z][A-Za-z]{2,})\1");

            MatchCollection destinations = pattern.Matches(text);

            int length = 0;
            List<string> result = new List<string>();

            foreach (Match destination in destinations)
            {
                string name = destination.Groups["name"].Value;
                result.Add(name);

                int currentLength = name.Length;

                length += currentLength;

            }

            Console.WriteLine($"Destinations: {string.Join(", ", result)}");
            Console.WriteLine($"Travel Points: {length}");
        }
    }
}