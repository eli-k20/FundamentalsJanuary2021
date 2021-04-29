using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> plantByRarity = new Dictionary<string, double>();
            Dictionary<string, List<double>> plantByRatings = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string name = parts[0];
                double rarity = double.Parse(parts[1]);

                if (plantByRarity.ContainsKey(name))
                {
                    plantByRarity[name] = rarity;
                    continue;
                }

                plantByRarity.Add(name, rarity);
                plantByRatings.Add(name, new List<double>());
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Exhibition")
                {
                    break;
                }

                string[] parts = line
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];

                if (command == "Rate")
                {
                    string[] info = parts[1]
                        .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                    string plant = info[0];
                    double rating = double.Parse(info[1]);

                    if (plantByRatings.ContainsKey(plant))
                    {
                        plantByRatings[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (command == "Update")
                {
                    string[] info = parts[1]
                        .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                    string plant = info[0];
                    double newRarity = double.Parse(info[1]);

                    if (plantByRarity.ContainsKey(plant))
                    {
                        plantByRarity[plant] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (command == "Reset")
                {
                    string plant = parts[1];

                    if (plantByRatings.ContainsKey(plant))
                    {
                        plantByRatings[plant].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            plantByRarity = plantByRarity
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => plantByRatings[x.Key].Count == 0 ? 0 : plantByRatings[x.Key].Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in plantByRarity)
            {
                List<double> ratings = plantByRatings[kvp.Key];

                double rating = 0;

                if (ratings.Count != 0)
                {
                    rating = ratings.Average();
                }

                Console.WriteLine($"- {kvp.Key}; Rarity: {kvp.Value}; Rating: {rating:F2}");
            }
        }
    }
}
