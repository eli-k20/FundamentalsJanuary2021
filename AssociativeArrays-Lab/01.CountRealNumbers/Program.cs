using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> occurencesOfNumbers = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!occurencesOfNumbers.ContainsKey(number))
                {
                    occurencesOfNumbers.Add(number, 1);
                }
                else
                {
                    occurencesOfNumbers[number]++;
                }
            }

            foreach (var pair in occurencesOfNumbers)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
            
        }
    }
}
