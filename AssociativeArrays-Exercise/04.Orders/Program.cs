using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productByPrice = new Dictionary<string, decimal>();
            Dictionary<string, int> productByQuantity = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "buy")
                {
                    break;
                }

                string[] parts = line.Split();

                string product = parts[0];
                decimal price = decimal.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);

                if (productByPrice.ContainsKey(product))
                {
                    productByPrice[product] = price;
                    productByQuantity[product] += quantity;
                }
                else
                {
                    productByPrice.Add(product, price);
                    productByQuantity.Add(product, quantity);
                }
            }

            foreach (var pair in productByPrice)
            {
                decimal price = pair.Value;
                int quantity = productByQuantity[pair.Key];

                decimal totalPrice = price * quantity;

                Console.WriteLine($"{pair.Key} -> {totalPrice:F2}");
            }
        }
    }
}
