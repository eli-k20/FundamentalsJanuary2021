using System;

namespace _07._RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            ConcatenatedString(input, repeat);
        }

        static string ConcatenatedString(string input, int repeat)
        {
            string result = String.Empty;

            for (int i = 0; i < repeat; i++)
            {
                Console.Write($"{input}");
            }

            Console.WriteLine();

            return result;
        }
    }
}
