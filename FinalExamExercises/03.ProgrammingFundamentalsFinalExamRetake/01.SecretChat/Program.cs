using System;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Reveal")
                {
                    break;
                }

                string[] parts = line
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(parts[1]);

                    message = message.Insert(index, " ");
                }
                else if (command == "Reverse")
                {
                    string substring = parts[1];
                    int start = message.IndexOf(substring);
                    int count = substring.Length;

                    if (message.Contains(substring))
                    {
                        string replace = string.Empty;
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            replace += substring[i];
                        }

                        message = message.Remove(start, count);
                        message += replace;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else
                {
                    string substring = parts[1];
                    string replacement = parts[2];

                    while (message.Contains(substring))
                    {
                        message = message.Replace(substring, replacement);
                    }
                }

                Console.WriteLine(message);
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
