﻿using System;

namespace _08._MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(number, power));
        }

        static double MathPower(double number, int power)
        {
            double result = Math.Pow(number, power);

            return result;
        }
    }
}
