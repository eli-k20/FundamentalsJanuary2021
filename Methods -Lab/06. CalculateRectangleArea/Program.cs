using System;
using System.Diagnostics.Contracts;

namespace _06._CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double result = RectangleArea(width, height);

            Console.WriteLine(result);
        }

        static double RectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
