using System;
using System.Linq;

namespace _02._CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();

            string[] secondArray = Console.ReadLine().Split();

            foreach (var secondElement in secondArray)
            {
                foreach (var firstElement in firstArray)
                {
                    if (secondElement == firstElement)
                    {
                        Console.Write($"{secondElement} ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
