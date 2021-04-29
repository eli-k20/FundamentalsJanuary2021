using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int bombNumber = bomb[0];
            int bombPower = bomb[1];

            while (true)
            {
                int index = numbers.IndexOf(bombNumber);
                if (index == -1)
                {
                    break;
                }

                int startIndex = index - bombPower;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                int countOfBombedNumbers = 2 * bombPower + 1;

                if (countOfBombedNumbers > numbers.Count - startIndex)
                {
                    countOfBombedNumbers = numbers.Count - startIndex;
                }

                numbers.RemoveRange(startIndex, countOfBombedNumbers);
            }

            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
