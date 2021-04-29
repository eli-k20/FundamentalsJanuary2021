using System;

namespace _11._MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Result(a, operation, b));
        }
        static double Result(int a, string operation, int b)
        {
            double result = 0.00;

            if (operation == "+")
            {
                result = a + b;
            }

            else if (operation == "-")
            {
                result = a - b;
            }

            else if (operation == "*")
            {
                result = a * b;
            }

            else if (operation == "/")
            {
                result = a / b;
            }

            return result;
        }
    }
}
