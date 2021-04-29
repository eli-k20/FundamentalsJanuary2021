using System;

namespace _01._ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = String.Empty;
            double total = 0;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "special" || command == "regular")
                {
                    break;
                }

                double currentPrice = double.Parse(command);

                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                total += currentPrice;
            }

            double taxes = 0.20 * total;
            double finalPrice = 0;

            if (total > 0)
            {
                if (command == "regular")
                {
                    finalPrice = total + taxes;
                }
                else
                {
                    finalPrice = (total + taxes) * 0.90;
                }

                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:F2}$"); 
                
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }


        }
    }
}
