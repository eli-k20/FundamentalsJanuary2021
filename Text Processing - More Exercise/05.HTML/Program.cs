using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();

            PrintTitle(articleTitle);
            PrintContent(articleContent);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of comments")
                {
                    break;
                }

                string comment = line;

                PrintComment(comment);
            }
        }

        private static void PrintComment(string comment)
        {
            Console.WriteLine($"<div>");
            Console.WriteLine($"    {comment}");
            Console.WriteLine($"</div>");
        }

        private static void PrintContent(string articleContent)
        {
            Console.WriteLine($"<article>");
            Console.WriteLine($"    {articleContent}");
            Console.WriteLine($"</article>");
        }

        private static void PrintTitle(string articleTitle)
        {
            Console.WriteLine($"<h1>");
            Console.WriteLine($"    {articleTitle}");
            Console.WriteLine($"</h1>");
        }
    }
}