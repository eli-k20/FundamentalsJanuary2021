using System;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex nameRegex = new Regex(@"@(?<name>[A-Za-z]+)\|");
            Regex ageRegex = new Regex(@"#(?<age>\d+)\*");

            for (int i = 0; i < n; i++)
            {
                string currentText = Console.ReadLine();

                Match nameMatch = nameRegex.Match(currentText);
                Match ageMatch = ageRegex.Match(currentText);

                if (nameMatch.Success && ageMatch.Success)
                {
                    string name = nameMatch.Groups["name"].Value;
                    int age = int.Parse(ageMatch.Groups["age"].Value);

                    Console.WriteLine($"{name} is {age} years old.");
                }
            }

        }
    }
}