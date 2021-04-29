using System;

namespace _03._FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double epsilon = 0.000001;

            if (a < b)
            {
                double smallerNum = a;
                a = b;
                b = smallerNum;
            }

            if (a - b < epsilon)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
