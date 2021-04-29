using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Orders(product, quantity);
        }

        static void Orders(string product, int quantity)
        {
            double price = 0;

            if (product == "coffee")
            {
                price = 1.50;
            }
            else if (product == "water")
            {
                price = 1;
            }
            else if (product == "coke")
            {
                price = 1.40;
            }
            else if (product == "snacks")
            {
                price = 2;
            }

            double result = price * quantity;

            Console.WriteLine($"{result:F2}");
        }

    }
}
