using System;

namespace _05._DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                int newSum = letter + key;

                char newLetter = (char)newSum;

                result += newLetter;

            }
            Console.WriteLine(result);


        }
    }
}
