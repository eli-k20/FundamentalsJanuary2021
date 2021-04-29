using System;
using System.Linq;

namespace _08._CondenseArraytoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int count = numbers.Length;

            while (count > 1)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                }
                count--;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
