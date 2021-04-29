using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._ChangeList
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

                string[] parts = input.Split();

                string command = parts[0];

                if (command == "Delete")
                {
                    int element = int.Parse(parts[1]);

                    numbers.RemoveAll(n => n == element);
                }
                else
                {
                    int element = int.Parse(parts[1]);
                    int position = int.Parse(parts[2]);

                    numbers.Insert(position, element);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
