using System;

namespace _02._VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = VowelsCounter(input);

            Console.WriteLine(result);
        }

        static int VowelsCounter(string input)
        {
            input = input.ToLower();

            int vowelsSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a'
                    || input[i] == 'e'
                    || input[i] == 'i'
                    || input[i] == 'o'
                    || input[i] == 'u')
                {
                    vowelsSum++;
                }
            }

            return vowelsSum;
        }
    }
}
