using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Craft!")
                {
                    break;
                }

                string[] parts = line
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command == "Collect")
                {
                    string currentItem = parts[1];

                    if (items.Contains(currentItem))
                    {
                        continue;
                    }
                    else
                    {
                        items.Add(currentItem);
                    }
                }

                else if (command == "Drop")
                {
                    string currentItem = parts[1];

                    if (items.Contains(currentItem))
                    {
                        items.Remove(currentItem);
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (command == "Combine Items")
                {
                    string currentItem = parts[1];

                    string[] currentParts = currentItem
                        .Split(":", StringSplitOptions.RemoveEmptyEntries);

                    string oldItem = currentParts[0];
                    string newItem = currentParts[1];

                    if (items.Contains(oldItem))
                    {
                        int index1 = items.IndexOf(oldItem);
                        items.Insert(index1 + 1, newItem);
                    }
                }

                else
                {
                    string currentItem = parts[1];
                    int index = items.IndexOf(currentItem);

                    if (items.Contains(currentItem))
                    {
                        items.Insert(items.Count, currentItem);
                        items.RemoveAt(index);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
