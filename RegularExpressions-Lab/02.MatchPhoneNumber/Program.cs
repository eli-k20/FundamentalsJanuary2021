using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            string[] matched = phoneMatches
                .Cast<Match>()
                .Select(p => p.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matched));
        }
    }
}
