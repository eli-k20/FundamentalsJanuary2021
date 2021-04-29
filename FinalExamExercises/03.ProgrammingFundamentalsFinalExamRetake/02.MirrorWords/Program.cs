using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex pattern = new Regex(@"(@|#)(?<first>[A-Za-z]{3,})\1{2}(?<second>[A-Za-z]{3,})\1");

            MatchCollection allMatches = pattern.Matches(text);

            List<string> mirrorWords = new List<string>();

            foreach (Match match in allMatches)
            {
                string first = match.Groups["first"].Value;
                string second = match.Groups["second"].Value;

                string secondReversed = string.Empty;
                for (int i = second.Length - 1; i >= 0; i--)
                {
                    secondReversed += second[i];
                }

                if (first.Equals(secondReversed))
                {
                    mirrorWords.Add($"{first} <=> {second}");
                }
            }

            if (allMatches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{allMatches.Count} word pairs found!");
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");

                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }
    }
}
