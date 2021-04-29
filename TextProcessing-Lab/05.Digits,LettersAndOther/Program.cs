using System;
using System.Text;

namespace _05.Digits_LettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            for (var i = 0; i < input.Length; i++)
            {
                var value = input[i];

                if (char.IsDigit(value))
                {
                    digits.Append(value);
                }
                else if (char.IsLetter(value))
                {
                    letters.Append(value);
                }
                else
                {
                    symbols.Append(value);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
