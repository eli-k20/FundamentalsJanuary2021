using System;
using System.Linq;

namespace _06._EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool exists = false;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                for (int j =  i - 1; j >= 0; j--)
                {
                    leftSum += array[j];
                }

                int rightSum = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                Console.WriteLine("no");
            }
        }
    }
}
