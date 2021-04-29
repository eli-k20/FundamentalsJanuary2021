using System;
using System.Linq;

namespace _04._PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = true;

            if (!AcceptedLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (ContainsInvalidCharacters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!AcceptedDigitsCount(password, 2))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool AcceptedDigitsCount(string password, int count)
        {
            int counter = 0;

            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    counter++;

                    if (counter == count)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool ContainsInvalidCharacters(string password)
        {
            foreach (var symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool AcceptedLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
