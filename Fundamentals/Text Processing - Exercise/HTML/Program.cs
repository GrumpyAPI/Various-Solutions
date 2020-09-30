using System;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = default;
            int counter = 0;

            while ((text = Console.ReadLine()) != "end of comments")
            {
                if (counter == 0)
                {
                    Console.WriteLine($"<h1>\n\t{text}\n</h1>");
                }
                else if (counter == 1)
                {
                    Console.WriteLine($"<article>\n\t{text}\n</article>");
                }
                else
                {
                    Console.WriteLine($"<div>\n\t{text}\n</div>");
                }
            }
        }
    }
}
