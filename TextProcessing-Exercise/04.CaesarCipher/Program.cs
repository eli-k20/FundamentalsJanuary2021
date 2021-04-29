using System;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            foreach (var letter in text)
            {
                char encryptedLetter = (char) (letter + 3);

                encryptedText.Append(encryptedLetter);
            }

            Console.WriteLine(encryptedText);
        }
    }
}
