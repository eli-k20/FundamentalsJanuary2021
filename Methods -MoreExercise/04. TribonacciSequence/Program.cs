using System;
using System.Numerics;

namespace _04._TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine(0);
            }
            else if (num == 1)
            {
                Console.Write(1);
            }
            else if (num == 2)
            {
                Console.Write("1 1");
            }
            else if (num == 3)
            {
                Console.Write("1 1 2");
            }
            else
            {
                Console.Write("1 1 2 ");
                GetTribonacci(num);
            }
        }

        private static void GetTribonacci(BigInteger num)
        {
            BigInteger first = 1;
            BigInteger second = 1;
            BigInteger third = 2;

            BigInteger max = num;

            for (int i = 0; i < max - 3; i++)
            {
                num = first + second + third;
                first = second;
                second = third;
                third = num;
                Console.Write("{0} ", num);
            }
        }
    }
}
