using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Yohoho!")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                if (command == "Loot")
                {
                    for (int i = 1; i < parts.Length; i++)
                    {
                        string item = parts[i];
                        if (!treasureChest.Contains(item))
                        {
                            treasureChest.Insert(0, item);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                else if (command == "Drop")
                {
                    int index = int.Parse(parts[1]);

                    if (index >= 0 && index < treasureChest.Count)
                    {
                        treasureChest.Add(treasureChest[index]);
                        treasureChest.RemoveAt(index);
                    }
                    else
                    {
                        continue;
                    }

                }

                else
                {
                    int count = int.Parse(parts[1]);

                    List<string> stolen = new List<string>();

                    if (treasureChest.Count <= count)
                    {
                        count = treasureChest.Count;
                    }

                    for (int i = treasureChest.Count - count; i < treasureChest.Count; i++)
                    {
                        stolen.Add(treasureChest[i]);
                    }

                    treasureChest.RemoveRange(treasureChest.Count - count, count);
                    Console.WriteLine(string.Join(", ", stolen));
                }
            }

            if (treasureChest.Count == 0)
            {
                Console.WriteLine($"Failed treasure hunt.");
            }
            else
            {
                double length = 0;

                for (int i = 0; i < treasureChest.Count; i++)
                {
                    string currentItem = treasureChest[i];
                    length += currentItem.Length;
                }

                double average = length / treasureChest.Count;
                Console.WriteLine($"Average treasure gain: {(average):F2} pirate credits.");
            }
        }
    }
}
