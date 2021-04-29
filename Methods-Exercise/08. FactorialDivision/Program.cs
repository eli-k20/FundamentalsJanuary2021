using System;

namespace _08._FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstFactorial = FactorialCalculator(firstNumber);
            double secondFactorial = FactorialCalculator(secondNumber);

            double division = firstFactorial / secondFactorial;

            Console.WriteLine($"{division:F2}");
        }

        static double FactorialCalculator(int number)
        {
            double factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
