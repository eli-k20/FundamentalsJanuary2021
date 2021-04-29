using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._RemoveNegativesandReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n >= 0)
                .Reverse()
                .ToList();

            Console.WriteLine(elements.Count > 0 ? string.Join(" ", elements) : "empty");
        }
    }
}
