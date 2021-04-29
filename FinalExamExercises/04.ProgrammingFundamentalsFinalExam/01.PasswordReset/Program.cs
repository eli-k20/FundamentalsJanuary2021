using System;

namespace _01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Done")
                {
                    break;
                }

                string[] parts = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command == "TakeOdd")
                {
                    string newPassword = string.Empty;

                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newPassword += password[i];
                        }
                    }

                    password = newPassword;
                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(parts[1]);
                    int count = int.Parse(parts[2]);

                    password = password.Remove(index, count);
                    Console.WriteLine(password);
                }
                else
                {
                    string substring = parts[1];
                    string replacement = parts[2];

                    if (!password.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }

                    password = password.Replace(substring, replacement);
                    Console.WriteLine(password);
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
