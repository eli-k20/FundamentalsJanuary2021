using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();

                if (word == "end")
                {
                    break;
                }

                string reversed = string.Empty;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed += word[i];
                }

                Console.WriteLine($"{word} = {reversed}");
            }

        }
    }
}
