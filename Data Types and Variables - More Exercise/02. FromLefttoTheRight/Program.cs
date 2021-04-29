using System;

namespace _02._FromLefttoTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                char delimiter = ' ';
                string[] splitNumbers = numbers.Split(delimiter);

                long leftNum = long.Parse(splitNumbers[0]);
                long rightNum = long.Parse(splitNumbers[1]);

                long biggerNumber = leftNum;

                if (rightNum > leftNum)
                {
                    biggerNumber = rightNum;
                }

                long sumOfDigits = 0;

                while (biggerNumber != 0)
                {
                    sumOfDigits += biggerNumber % 10;
                    biggerNumber /= 10;
                }
                Console.WriteLine(Math.Abs(sumOfDigits));
            }
        }
    }
}
