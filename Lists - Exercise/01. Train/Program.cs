using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;              
                }

                string[] parts = input.Split();

                if (parts.Length == 2)
                {
                    int addedPassangers = int.Parse(parts[1]);

                    wagons.Add(addedPassangers);
                }

                else
                {
                    int passangers = int.Parse(parts[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagonPassangers = wagons[i];

                        if (currentWagonPassangers + passangers <= maxCapacity )
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
