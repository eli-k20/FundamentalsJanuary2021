using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex digitsRegex = new Regex(@"\d");

            MatchCollection digitMatches = digitsRegex.Matches(text);

            int treshold = 1;
            foreach (Match match in digitMatches)
            {
                string digitString = match.ToString();
                int digit = int.Parse(digitString);
                treshold *= digit;
            }

            Regex emojiRegex = new Regex(@"(::|\*\*)(?<name>[A-Z][a-z]{2,})\1");

            MatchCollection emojiMatches = emojiRegex.Matches(text);

            List<string> emojiList = new List<string>();

            foreach (Match match in emojiMatches)
            {
                string emojiName = match.Groups["name"].Value;
                string delimiter = match.Groups[1].Value;

                int currentSum = 0;

                for (int i = 0; i < emojiName.Length; i++)
                {
                    currentSum += emojiName[i];
                }

                if (currentSum >= treshold)
                {
                    emojiList.Add($"{delimiter}{emojiName}{delimiter}");
                }
            }

            Console.WriteLine($"Cool threshold: {treshold}");
            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");

            foreach (var emoji in emojiList)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
