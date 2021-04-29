using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                int firstIndex = 0;
                int secondIndex = 0;

                if (command == "swap")
                {
                    firstIndex = int.Parse(parts[1]);
                    secondIndex = int.Parse(parts[2]);

                    long swapped = numbers[firstIndex];

                    numbers[firstIndex] = numbers[secondIndex];
                    numbers[secondIndex] = swapped;
                }

                else if (command == "multiply")
                {
                    firstIndex = int.Parse(parts[1]);
                    secondIndex = int.Parse(parts[2]);

                    long result = numbers[firstIndex] * numbers[secondIndex];

                    numbers[firstIndex] *= numbers[secondIndex];
                    //if (firstIndex < secondIndex)
                    //{
                    //    numbers.Insert(firstIndex, result);
                    //    numbers.RemoveAt(secondIndex);
                    //}
                    //else
                    //{
                    //    numbers.RemoveAt(firstIndex);
                    //    numbers.Insert(firstIndex, result);
                    //}
                }

                else if (command == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]--;
                    }
                }
            }

            Console.Write(string.Join(", ", numbers));
            Console.WriteLine();
            
        }
    }
}
