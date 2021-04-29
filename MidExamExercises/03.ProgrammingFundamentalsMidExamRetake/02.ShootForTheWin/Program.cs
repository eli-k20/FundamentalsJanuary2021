using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 0;
            bool shoted = false;

            while (true)
            {
                int originalValue = 0;

                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                int targetIndex = int.Parse(line);

                if (targetIndex < 0 || targetIndex >= targets.Length)
                {
                    continue;
                }

                originalValue = targets[targetIndex];

                targets[targetIndex] = -1;
                counter++;
                shoted = true;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] > originalValue && targets[i] != -1)
                    {
                        targets[i] -= originalValue;
                    }
                    else if (targets[i] <= originalValue && targets[i] != -1)
                    {
                        targets[i] += originalValue;
                    }
                }

            }

            Console.Write($"Shot targets: {counter} -> ");
            Console.WriteLine(string.Join(" ", targets));
        }
    }
}
