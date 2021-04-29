using System;

namespace _07._WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentLitres = int.Parse(Console.ReadLine());

                if (currentLitres > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                sum += currentLitres;
                capacity -= currentLitres;
            }

            Console.WriteLine($"{sum}");
        }
    }
}
