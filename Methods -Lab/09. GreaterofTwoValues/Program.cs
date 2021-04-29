using System;

namespace _09._GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();

            if (valueType == "int")
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(number1, number2));
            }

            else if (valueType == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());

                Console.WriteLine((char)GetMax(char1, char2));
            }

            else if (valueType == "string")
            {
                string string1 = Console.ReadLine();
                string string2 = Console.ReadLine();

                Console.WriteLine(GetMax(string1, string2));
            }
        }

        static int GetMax(int number1, int number2)
        {
            return Math.Max(number1, number2); 
        }

        static string GetMax(string string1, string string2)
        {
            if (string1.CompareTo(string2) >= 0)
            {
                return string1;
            }
            else
            {
                return string2;
            }
        }
    }
}
