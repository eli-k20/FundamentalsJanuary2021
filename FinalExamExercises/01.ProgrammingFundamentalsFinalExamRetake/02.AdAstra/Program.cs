using System;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            Regex regex =
                new Regex(@"(#|\|)(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<kcal>\d{1,4}|10000)\1");

            MatchCollection matches = regex.Matches(text);

            int sum = 0;

            foreach (Match match in matches)
            {
                int calories = int.Parse(match.Groups["kcal"].Value);

                sum += calories;
            }

            Console.WriteLine($"You have food to last you for: {sum / 2000} days!");

            foreach (Match match in matches)
            {
                string name = match.Groups["name"].Value;
                string date = match.Groups["date"].Value;
                int calories = int.Parse(match.Groups["kcal"].Value);

                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}