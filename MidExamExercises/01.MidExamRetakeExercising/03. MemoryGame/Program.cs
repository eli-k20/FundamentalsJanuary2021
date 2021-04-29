using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int numberOfMoves = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                numberOfMoves++;

                string[] parts = line.Split();

                int firstIndex = int.Parse(parts[0]);
                int secondIndex = int.Parse(parts[1]);

                if (firstIndex >= 0 && secondIndex >= 0 && firstIndex < elements.Count && secondIndex < elements.Count 
                    && firstIndex != secondIndex)
                {
                    if (elements[firstIndex] == elements[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");

                        if (firstIndex > secondIndex)
                        {
                            elements.RemoveAt(firstIndex);
                            elements.RemoveAt(secondIndex);
                        }
                        else
                        {
                            elements.RemoveAt(secondIndex);
                            elements.RemoveAt(firstIndex);
                        }

                        if (elements.Count == 0)
                        {
                            Console.WriteLine($"You have won in {numberOfMoves} turns!");
                            return;
                        }
                    }
                    else if (elements[firstIndex] != elements[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }

                }
                else
                {
                    elements.Insert(elements.Count / 2, $"-{numberOfMoves}a");
                    elements.Insert(elements.Count / 2, $"-{numberOfMoves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
