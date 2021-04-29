using System;

namespace _01.SmallestofThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int result = SmallestNumber(number1, number2, number3);

            Console.WriteLine(result);
        }

        static int SmallestNumber(int number1, int number2, int number3)
        {
            return Math.Min(Math.Min(number1, number2), number3);
        }
    }
}
