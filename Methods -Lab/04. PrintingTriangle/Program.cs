using System;

namespace _04._PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse((Console.ReadLine()));

            for (int i = 1; i <= n; i++)
            {
                PrintTriangle(i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintTriangle(i);
            }
        }

        static void PrintTriangle(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
