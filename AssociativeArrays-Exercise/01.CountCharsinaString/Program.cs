using System;
using System.Collections.Generic;

namespace _01.CountCharsinaString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                foreach (var letter in word)
                {
                    if (count.ContainsKey(letter))
                    {
                        count[letter]++;
                    }
                    else
                    {
                        count.Add(letter, 1);
                    }
                }
            }

            foreach (var pair in count)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}
