using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
{
    class City
    {
        public int Population { get; set; }

        public int Gold { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Sail")
                {
                    break;
                }

                string[] parts = line
                    .Split("||", StringSplitOptions.RemoveEmptyEntries);

                if (cities.ContainsKey(parts[0]))
                {
                    cities[parts[0]].Population += int.Parse(parts[1]);
                    cities[parts[0]].Gold += int.Parse(parts[2]);
                }
                else
                {
                    cities.Add(parts[0], new City {Population = int.Parse(parts[1]), Gold = int.Parse(parts[2])});
                }
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command == "Plunder")
                {
                    string town = parts[1];
                    int people = int.Parse(parts[2]);
                    int gold = int.Parse(parts[3]);

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    cities[town].Population -= people;
                    cities[town].Gold -= gold;

                    if (cities[town].Population == 0 || cities[town].Gold == 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }

                else
                {
                    string town = parts[1];
                    int gold = int.Parse(parts[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }

                    cities[town].Gold += gold;
                    Console.WriteLine(
                        $"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
                }
            }

            cities = cities.OrderByDescending(x => x.Value.Gold)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var kvp in cities)
                {
                    Console.WriteLine(
                        $"{kvp.Key} -> Population: {kvp.Value.Population} citizens, Gold: {kvp.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
