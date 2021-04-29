using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> qualityOfDrums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> price = new List<int>();
            price.AddRange(qualityOfDrums);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Hit it again, Gabsy!")
                {
                    break;
                }

                int hitPower = int.Parse(line);

                for (int i = 0; i < qualityOfDrums.Count; i++)
                {
                    qualityOfDrums[i] -= hitPower;

                    if (qualityOfDrums[i] <= 0)
                    {
                        if (savings - (price[i] * 3) >= 0)
                        {
                            savings -= (price[i] * 3);
                            qualityOfDrums[i] = price[i];
                        }
                    }

                }

                for (int i = 0; i < qualityOfDrums.Count; i++)
                {
                    if (qualityOfDrums[i] <= 0)
                    {
                        qualityOfDrums.Remove(qualityOfDrums[i]);
                        price.Remove(price[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", qualityOfDrums));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
