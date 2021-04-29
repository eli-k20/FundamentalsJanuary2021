using System;

namespace _10._PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int counter = 0;
            int originalPower = pokePower;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                counter++;

                if (pokePower == (originalPower / 2.00))
                {
                    if (exhaustionFactor > 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
