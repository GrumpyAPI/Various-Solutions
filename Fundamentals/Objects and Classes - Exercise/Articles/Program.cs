using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleArgs = Console.ReadLine()
                .Split(", ");

            string title = articleArgs[0];
            string content = articleArgs[1];
            string author = articleArgs[2];

            Article article = new Article(title, content, author);

            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(": ");

                string command = commandArgs[0];

                if (command == "Edit")
                {
                    string newContent = commandArgs[1];
                    article.Edit(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = commandArgs[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if (command == "Rename")
                {
                    string newTitle = commandArgs[1];
                    article.Rename(newTitle);
                }
            }

            Console.WriteLine(article);
            //Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");    // Without overriding the ".ToString()" method.
        }
    }
}
