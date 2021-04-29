using System;
using System.Linq;

namespace _04._ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());
            rotations = rotations % array.Length;

            for (int i = 0; i < rotations; i++)
            {
                int firstElement = array[0];

                for (int j = 1; j < array.Length; j++)
                {
                    int previuosIndex = j - 1;
                    array[previuosIndex] = array[j];
                }

                array[array.Length - 1] = firstElement; 
            }

            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}
