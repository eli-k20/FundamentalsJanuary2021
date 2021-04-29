using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currentIndex = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Love!")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];
                int length = int.Parse(parts[1]);

                currentIndex += length;

                if (currentIndex >= houses.Length)
                {
                    currentIndex = 0;
                }

                if (houses[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }
                else
                {
                    houses[currentIndex] -= 2;

                    if (houses[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                }
            }

            int housesWithoutVD = houses
                .Where(h => h > 0)
                .Count();


            Console.WriteLine($"Cupid's last position was {currentIndex}.");

            Console.WriteLine(housesWithoutVD > 0
                ? $"Cupid has failed {housesWithoutVD} places."
                : $"Mission was successful.");
        }
    }
}
