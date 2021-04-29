using System;

namespace _06._BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int openCount = 0;
            int closedCount = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openCount++;
                }
                else if (input == ")")
                {
                    closedCount++;
                }

                if (closedCount > openCount)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }

            if (openCount == closedCount)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
