using System;
using System.Collections.Generic;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numOfMessages = byte.Parse(Console.ReadLine());

            string[] phrases = { "Exellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exeptional product.", "I can't live without this product." };
            string[] events = { "Now i feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now i feel awesome.", "Try it yourself, i am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();
            List<Message> messages = new List<Message>();

            for (int i = 0; i < numOfMessages; i++)
            {
                int randomPhrase = rnd.Next(0, phrases.Length);
                int randomEvent = rnd.Next(0, events.Length);
                int randomAuthor = rnd.Next(0, authors.Length);
                int randomCity = rnd.Next(0, cities.Length);

                Message message = new Message()
                {
                    Phrase = phrases[randomPhrase],
                    Event = events[randomEvent],
                    Author = authors[randomAuthor],
                    City = cities[randomCity]
                };

                messages.Add(message);
            }

            foreach (Message message in messages)
            {
                Console.WriteLine($"{message.Phrase} {message.Event} {message.Author} - {message.City}");
            }
        }
    }
}
