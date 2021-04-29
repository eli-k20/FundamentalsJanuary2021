using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] currentArticle = Console.ReadLine()
                    .Split(", ");

                Article newArticle = new Article()
                {
                    Title = currentArticle[0],
                    Content = currentArticle[1],
                    Author = currentArticle[2]
                };

                articles.Add(newArticle);
            }

            string sortingCriteria = Console.ReadLine();

            List<Article> sorted = new List<Article>();

            if (sortingCriteria == "title")
            {
                sorted = articles
                    .OrderBy(x => x.Title)
                    .ToList();
            }
            else if (sortingCriteria == "content")
            {
                sorted = articles
                    .OrderBy(x => x.Content)
                    .ToList();
            }
            else
            {
                sorted = articles
                    .OrderBy(x => x.Author)
                    .ToList();
            }

            foreach (var article in sorted)
            {
                Console.WriteLine(article);
            }
        }
    }
}
