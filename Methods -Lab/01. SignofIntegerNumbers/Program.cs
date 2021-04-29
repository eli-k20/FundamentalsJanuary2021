using System;

namespace _01._SignОfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSign(int.Parse(Console.ReadLine()));
        }

        static void PrintSign(int number)
        {
            string sign = String.Empty;

            if (number > 0)
            {
                sign = "positive";
            }
            else if (number < 0)
            {
                sign = "negative";
            }
            else
            {
                sign = "zero";
            }

            Console.WriteLine($"The number {number} is {sign}.");
        }
    }
}
