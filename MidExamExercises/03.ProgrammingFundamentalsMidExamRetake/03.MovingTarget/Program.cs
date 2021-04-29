using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool shot = false;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                if (command == "Shoot")
                {
                    int index = int.Parse(parts[1]);
                    int power = int.Parse(parts[2]);

                    if (IsValid(index, targets))
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            shot = true;
                            targets.RemoveAt(index);
                        }
                    }
                }

                else if (command == "Add")
                {
                    int index = int.Parse(parts[1]);
                    int value = int.Parse(parts[2]);

                    if (IsValid(index, targets))
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }

                else if (command == "Strike")
                {
                    int index = int.Parse(parts[1]);
                    int radius = int.Parse(parts[2]);

                    int startIndex = index - radius;
                    int endIndex = index + radius;

                    int countOfBombedNumbers = 2 * radius + 1;

                    if (startIndex < 0 || startIndex >= targets.Count
                                       || endIndex >= targets.Count || endIndex < 0)
                    {
                        Console.WriteLine("Strike missed!");
                    }

                    else
                    {
                        targets.RemoveRange(startIndex, countOfBombedNumbers);
                    }

                }
            }

            Console.WriteLine(string.Join("|", targets));
        }

        private static bool IsValid(int index, List<int> targets)
        {
            return index >= 0 && index < targets.Count;
        }
    }
}
