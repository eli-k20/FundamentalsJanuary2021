using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> warShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool sunken = false;

            int maxHealthCapacityPerSection = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Retire" || sunken == true)
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                if (command == "Fire")
                {
                    int index = int.Parse(parts[1]);
                    int damage = int.Parse(parts[2]);

                    if (index >= 0 && index < warShip.Count)
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            sunken = true;
                            break;
                        }
                    }
                }

                else if (command == "Defend")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);
                    int damage = int.Parse(parts[3]);

                    if (startIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            
                            if (pirateShip[i] <= 0) 
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                sunken = true;
                                break;
                            }
                            
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (command == "Repair")
                {
                    int index = int.Parse(parts[1]);
                    int health = int.Parse(parts[2]);

                    if (index >= 0 && index < pirateShip.Count)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] + health > maxHealthCapacityPerSection)
                        {
                            pirateShip[index] = maxHealthCapacityPerSection;
                        }
                    }
                }

                else
                {
                    int counter = 0;

                    foreach (var section in pirateShip)
                    {
                        if (section < 0.20 * maxHealthCapacityPerSection)
                        {
                            counter++;
                        }
                    }

                    Console.WriteLine($"{counter} sections need repair.");
                }
            }

            if (!sunken)
            {
                int pirateShipSum = pirateShip.Sum();
                int warshipSum = warShip.Sum();

                Console.WriteLine($"Pirate ship status: {pirateShipSum}");
                Console.WriteLine($"Warship status: {warshipSum}");
            }
        }
    }
}
