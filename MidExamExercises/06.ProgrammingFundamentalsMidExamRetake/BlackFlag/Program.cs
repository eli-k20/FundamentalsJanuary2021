using System;
using System.ComponentModel.Design;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int plunderPerDay = int.Parse(Console.ReadLine());
            double plunderExpected = double.Parse(Console.ReadLine());


            double totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += plunderPerDay;

                if (i % 3 == 0)
                {
                    totalPlunder += (plunderPerDay * 0.50);
                }

                if (i % 5 == 0)
                {
                    totalPlunder *= 0.70;
                }
            }

            double percentage = totalPlunder / (plunderExpected / 100);

            if (totalPlunder >= plunderExpected)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }

        }
    }
}
