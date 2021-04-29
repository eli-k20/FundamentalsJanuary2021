using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> newList = new List<int>();

            double averageSum = numbers.Average();

            newList = numbers
                .OrderByDescending(x => x)
                .Where(num => num > averageSum)
                .Take(5)
                .ToList();

            Console.WriteLine(newList.Count <= 0 ? "No" : string.Join(" ", newList));
        }
    }
}
