using System;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split("|");

            string firstPart = text[0];
            string secondPart = text[1];
            string thirdPart = text[2];

            Regex capitalLettersRegex = new Regex(@"(#|\$|%|\*|&)(?<capitals>[A-Z]+)\1");

            Match capitalsMatch = capitalLettersRegex.Match(firstPart);

            string capitals = capitalsMatch.Groups["capitals"].Value;

            for (int index = 0; index < capitals.Length; index++)
            {
                char startLetter = capitals[index];
                int ASCIIcode = startLetter;

                string secondPattern = $@"{ASCIIcode}:(?<length>[0-9][0-9])";
                Match secondMatch = Regex.Match(secondPart, secondPattern);

                int length = int.Parse(secondMatch.Groups["length"].Value);

                string thirdPattern = $@"(?<=\s|^){startLetter}[^\s]{{{length}}}(?=\s|$)";
                Match thirdMatch = Regex.Match(thirdPart, thirdPattern);

                string word = thirdMatch.ToString();

                Console.WriteLine(word);
            }

        }
    }
}