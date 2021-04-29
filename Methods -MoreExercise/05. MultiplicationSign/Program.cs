using System;

namespace _05._MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            MultiplicationSign(num1, num2, num3);
            
        }

        private static void MultiplicationSign(int num1, int num2, int num3)
        {
            int minusCounter = 0;

            if (num1 < 0)
            {
                minusCounter++;
            }
            if (num2 < 0)
            {
                minusCounter++;
            }
            if (num3 < 0)
            {
                minusCounter++;
            }


            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine(minusCounter % 2 == 0 ? "positive" : "negative");
            }
        }
    }
}
