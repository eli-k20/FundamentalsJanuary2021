using System;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in usernames)
            {
                if (HasValidLength(name) && ContainsValidSymbols(name))
                {
                    Console.WriteLine(name);
                }
            }
        }

        private static bool ContainsValidSymbols(string name)
        {
            foreach (char symbol in name)
            {
                if (!char.IsLetterOrDigit(symbol) && symbol != '-' && symbol != '_')
                {
                    return false;
                }
            }

            return true;
        }

        private static bool HasValidLength(string name)
        {
            return name.Length >= 3 && name.Length <= 16;
        }
    }
}
