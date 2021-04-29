﻿using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            int index = text.IndexOf(wordToRemove);

            text = text.Remove(index, wordToRemove.Length);

            while (text.Contains(wordToRemove))
            {
                index = text.IndexOf(wordToRemove);
                text = text.Remove(index, wordToRemove.Length);
            }

            Console.WriteLine(text);
        }
    }
}