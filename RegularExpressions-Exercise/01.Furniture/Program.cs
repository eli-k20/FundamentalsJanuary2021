using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^>>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)");

            double totalPrice = 0;

            List<string> furniture = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Purchase")
                {
                    break;
                }

                Match match = pattern.Match(line);

                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups["name"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);

                furniture.Add(name);
                totalPrice += price * quantity;
            }

            Console.WriteLine("Bought furniture:");

            foreach (string item in furniture)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
