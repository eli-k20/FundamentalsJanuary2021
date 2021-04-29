using System;

namespace _09._SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            if (startingYield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }

            else
            {
                int yieldLeft = 0;
                int total = 0;
                int days = 0;
                int workersConsume = 26;

                while (startingYield >= 100)
                {
                    days++;
                    yieldLeft = startingYield - workersConsume;
                    total += yieldLeft;
                    startingYield -= 10;

                    if (startingYield < 100)
                    {
                        total -= workersConsume;
                    }

                }

                Console.WriteLine(days);
                Console.WriteLine(total);
            }
        }
    }
}
