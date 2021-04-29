using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)[^|$%.]*\$$");

            double totalIncome = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of shift")
                {
                    break;
                }

                Match match = pattern.Match(line);

                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups["name"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                double price = double.Parse(match.Groups["price"].Value);

                double customerIncome = price * count;
                totalIncome += customerIncome;

                Console.WriteLine($"{name}: {product} - {customerIncome:F2}");
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
