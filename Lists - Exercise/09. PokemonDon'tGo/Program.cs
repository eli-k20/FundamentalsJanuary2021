using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int removedElement = 0;

            while (true)
            {
                int currentIndex = int.Parse(Console.ReadLine());

                if (currentIndex < 0)
                {
                    removedElement = pokemons[0];
                    sum += removedElement;
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else if (currentIndex >= pokemons.Count)
                {
                    removedElement = pokemons[pokemons.Count - 1]; ;
                    sum += removedElement;
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                else
                {
                    removedElement = pokemons[currentIndex];
                    sum += removedElement;
                    pokemons.RemoveAt(currentIndex);
                }

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= removedElement)
                    {
                        pokemons[i] += removedElement;
                    }
                    else
                    {
                        pokemons[i] -= removedElement;
                    }
                }

                if (pokemons.Count == 0)
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
