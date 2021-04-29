using System;
using System.Linq;

namespace _03._Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            int[] second = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentArray = Console.ReadLine().
                    Split().
                    Select(int.Parse).
                    ToArray();

                int firstNum = currentArray[0];
                int secondNum = currentArray[1];

                if (i % 2 == 0)
                {
                    first[i] = firstNum;
                    second[i] = secondNum;
                }

                else
                {
                    first[i] = secondNum;
                    second[i] = firstNum;
                }
            }

            Console.WriteLine(string.Join(' ', first));
            Console.WriteLine(string.Join(' ', second));
        }
    }
}
