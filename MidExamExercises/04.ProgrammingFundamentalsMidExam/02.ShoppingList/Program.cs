using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Go Shopping!")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                if (command == "Urgent")
                {
                    string item = parts[1];

                    if (groceries.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        groceries.Insert(0, item);
                    }
                }
            

                else if (command == "Unnecessary")
                {
                    string item = parts[1];

                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (command == "Correct")
                {
                    string item = parts[1];
                    string newItem = parts[2];

                    if (groceries.Contains(item))
                    {
                        int firstIndex = groceries.IndexOf(item);
                        groceries.Remove(item);
                        groceries.Insert(firstIndex, newItem);
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (command == "Rearrange")
                {
                    string item = parts[1];

                    if (groceries.Contains(item))
                    {
                        int index = groceries.IndexOf(item);
                        groceries.RemoveAt(index);
                        groceries.Add(item);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
