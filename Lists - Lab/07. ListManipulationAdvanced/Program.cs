using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool isChanged = false;

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
                    isChanged = true;
                }

                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(command[1]);
                    numbers.Remove(numberToRemove);
                    isChanged = true;
                }

                else if (action == "RemoveAt")
                {
                    int indexToRemoveAt = int.Parse(command[1]);
                    numbers.RemoveAt(indexToRemoveAt);
                    isChanged = true;
                }

                else if (action == "Insert")
                {
                    int numberToInsert = int.Parse(command[1]);
                    int indexToInsertAt = int.Parse(command[2]);
                    numbers.Insert(indexToInsertAt, numberToInsert);
                    isChanged = true;
                }

                else if (action == "Contains")
                {
                    int containedNumber = int.Parse(command[1]);

                    Console.WriteLine(numbers.Contains(containedNumber) ? "Yes" : "No such number");
                }

                else if (action == "PrintEven")
                {
                    foreach (var element in numbers)
                    {
                        if (element % 2 == 0)
                        {
                            Console.Write($"{element} ");
                        }

                    }

                    Console.WriteLine();
                }

                else if (action == "PrintOdd")
                {
                    foreach (var element in numbers)
                    {
                        if (element % 2 != 0)
                        {
                            Console.Write($"{element} ");
                        }
                    }

                    Console.WriteLine();
                }

                else if (action == "GetSum")
                {
                    Console.WriteLine($"{numbers.Sum()}");
                }

                else if (action == "Filter")
                {
                    int number = int.Parse(command[2]);

                    if (command[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
                    }

                    else if (command[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
                    }

                    else if (command[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                    }

                    else if (command[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                    }
                }

            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }

}
