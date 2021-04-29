using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplyBigNumbers(number, multiplier));
        }

        private static string MultiplyBigNumbers(string number, int multiplier)
        {
            if (multiplier == 0)
            {
                return "0";
            }

            int reminder = 0;

            StringBuilder result = new StringBuilder();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';

                reminder += multiplier * digit;

                if (reminder > 9)
                {
                    int reminderLastDigit = reminder % 10;
                    reminder /= 10;

                    result.Append(reminderLastDigit.ToString());
                }
                else
                {
                    result.Append(reminder.ToString());
                    reminder = 0;
                }
            }

            if (reminder > 0)
            {
                result.Append(reminder.ToString());
            }

            return string.Concat(result.ToString().Reverse());
        }
    }
}
