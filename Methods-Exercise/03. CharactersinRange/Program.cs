using System;

namespace _03._CharactersinRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            char start = first;
            char end = second;

            if (first > second)
            {
                start = second;
                end = first;
            }

            Range(start, end);
        }

        static void Range(char start, char end)
        {
            for (char i = (char)(start + 1); i < end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
