using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> oddTimes = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerCase = word.ToLower();

                if (oddTimes.ContainsKey(lowerCase))
                {
                    oddTimes[lowerCase]++;
                }
                else
                {
                    oddTimes.Add(lowerCase, 1);
                }
            }

            foreach (var wordCount in oddTimes)
            {
                if (wordCount.Value % 2 != 0)
                {
                    Console.Write(wordCount.Key + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
