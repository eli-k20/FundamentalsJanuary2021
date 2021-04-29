using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine()
                .Split("\\");

            string fullName = path[path.Length - 1];

            string[] fullNameParts = fullName.Split(".");

            string extension = fullNameParts[fullNameParts.Length - 1];
            string name = fullName.Replace($".{extension}", "");

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
