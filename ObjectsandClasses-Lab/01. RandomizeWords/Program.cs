using System;
using System.Linq;

namespace _01._RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int position = random.Next(words.Length);

                string word = words[i];
                words[i] = words[position];
                words[position] = word;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
