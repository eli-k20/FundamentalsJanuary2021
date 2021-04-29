using System;
using System.Linq;
using System.Threading;

namespace _01.Encrypt_SortandPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int sum = 0;
            string vowels = "EeUuIiOoAa";

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                string currentName = Console.ReadLine();

                for (int j = 0; j < currentName.Length; j++)
                {
                    char currentChar = currentName[j];

                    if (vowels.Contains(currentChar))
                    {
                        sum += currentChar * currentName.Length;
                    }

                    else
                    {
                        sum += currentChar / currentName.Length;
                    }
                }

                numbers[i] = sum;
                sum = 0;
            }

            Array.Sort(numbers);
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }
        }
    }
}
