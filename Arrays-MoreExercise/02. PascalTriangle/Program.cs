using System;
using System.Diagnostics.CodeAnalysis;

namespace _02._PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            long[][] triangle = new long[height + 1][];

            for (int row = 0; row < height; row++)
            {
                triangle[row] = new long[row + 1];
            }

            triangle[0][0] = 1;

            for (int row = 0; row < height - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            for (int row = 0; row < height; row++)
            {
                Console.WriteLine(string.Join(" ", triangle[row]));
            }
        }
    }
}
