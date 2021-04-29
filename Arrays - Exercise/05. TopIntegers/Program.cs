using System;
using System.Linq;

namespace _05._TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                bool isTopNumber = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    int rightNumber = array[j];

                    if (rightNumber >= currentNumber)
                    {
                        isTopNumber = false;
                        break;
                    }
                }

                if (isTopNumber)
                {
                    Console.Write($"{currentNumber} ");
                }
            }

            Console.WriteLine();
        }
    }
}
