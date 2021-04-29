using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex pattern = new Regex(@"(^|(?<=\s))[A-Za-z\d]+([.\-_][A-Za-z\d]+)*@[A-Za-z]+(\-[A-Za-z]+)*(\.[A-Za-z]+)+");

            MatchCollection matches = pattern.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
