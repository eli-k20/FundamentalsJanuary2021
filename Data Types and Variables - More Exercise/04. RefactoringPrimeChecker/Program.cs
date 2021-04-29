using System;

namespace _04._RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                string isPrime = "true";

                for (int divider = 2; divider < i; divider++)
                {
                    if (i % divider == 0)
                    {
                        isPrime= "false";
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime);
            }

        }
    }
}
