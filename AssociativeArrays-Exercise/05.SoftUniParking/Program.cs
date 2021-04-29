﻿using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split();

                string command = parts[0];

                if (command == "register")
                {
                    string username = parts[1];
                    string plateNumber = parts[2];

                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                    else
                    {
                        users.Add(username, plateNumber);
                        Console.WriteLine($"{username} registered {plateNumber} successfully");
                    }
                }
                else
                {
                    string username = parts[1];
                    bool removed = users.Remove(username);

                    if (removed)
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var pair in users)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
