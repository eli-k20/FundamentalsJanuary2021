using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Decode")
                {
                    break;
                }

                string[] parts = line.Split('|');
                string command = parts[0];

                switch (command)
                {
                    case "Move":
                        int count = int.Parse(parts[1]);
                        if (count > message.Length)
                        {
                            count = message.Length;
                        }
                        string substring = message.Substring(0, count);
                        message = message.Remove(0, count);
                        message = message.Insert(message.Length, substring);
                        break;
                    case "Insert":
                        int index = int.Parse(parts[1]);
                        string value = parts[2];
                        if (index >= 0 && index <= message.Length)
                        {
                            message = message.Insert(index, value);
                        }
                        break;
                    case "ChangeAll":
                        string oldValue = parts[1];
                        string newValue = parts[2];
                        message = message.Replace(oldValue, newValue);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}