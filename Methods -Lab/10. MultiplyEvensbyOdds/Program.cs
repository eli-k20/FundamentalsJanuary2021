using System;

namespace _10._MultiplyEvensbyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Result(number));
        }

        static int Result(int number)
        {
            int evenSum = 0;
            int oddSum = 0;

            while (Math.Abs(number) > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                else
                {
                    oddSum += lastDigit;
                }

                number /= 10;
            }

            int result = evenSum * oddSum;
            return result;
        }
    }
}
