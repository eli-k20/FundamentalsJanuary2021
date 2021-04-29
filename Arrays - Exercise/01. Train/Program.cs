using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());

            int[] wagon = new int[wagonsCount];
            int sum = 0;

            for (int i = 0; i < wagon.Length; i++)
            {
                wagon[i] = int.Parse(Console.ReadLine());
                sum += wagon[i];
            }

            Console.WriteLine(string.Join(' ', wagon));
            Console.WriteLine(sum);
        }
    }
}
