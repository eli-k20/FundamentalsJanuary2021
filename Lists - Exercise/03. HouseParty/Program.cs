using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                List<string> commands = Console.ReadLine()
                    .Split()
                    .ToList();

                string name = commands[0];

                if (commands.Count == 3)
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }

                else
                {
                    bool removed = guests.Remove(name);

                    if (!removed)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
