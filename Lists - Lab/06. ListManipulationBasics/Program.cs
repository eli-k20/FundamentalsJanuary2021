using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] command = input.Split();

                string action = command[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(command[1]);
                    numbers.Add(numberToAdd);
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(command[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (action == "RemoveAt")
                {
                    int indexToRemoveAt = int.Parse(command[1]);
                    numbers.RemoveAt(indexToRemoveAt);
                }
                else if (action == "Insert")
                {
                    int numberToInsert = int.Parse(command[1]);
                    int indexToInsertAt = int.Parse(command[2]);
                    numbers.Insert(indexToInsertAt, numberToInsert);
                }

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
