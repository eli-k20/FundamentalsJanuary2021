using System;
using System.Xml;

namespace _01._DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int currentInt = int.Parse(Console.ReadLine());
                PrintResult(currentInt);
            }

            else if (input == "real")
            {
                double currentDouble = double.Parse(Console.ReadLine());
                PrintResult(currentDouble);
            }
            else
            {
                string line = Console.ReadLine();
                PrintResult(line);
            }
        }

        private static void PrintResult(int currentInt)
        {
            Console.WriteLine(currentInt * 2);
        }

        private static void PrintResult(double currentDouble)
        {
            Console.WriteLine($"{currentDouble * 1.5:F2}");
        }

        private static void PrintResult(string line)
        {
            Console.WriteLine($"${line}$");
        }
    }
}
