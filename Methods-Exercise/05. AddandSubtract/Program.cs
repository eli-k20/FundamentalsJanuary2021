using System;
using System.Linq;

namespace _05._AddandSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = Sum(first, second);
            int diff = Substract(sum, third);

            Console.WriteLine(diff);
        }

        static int Substract(int first, int second)
        {
            return first - second;
        }

        static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}
