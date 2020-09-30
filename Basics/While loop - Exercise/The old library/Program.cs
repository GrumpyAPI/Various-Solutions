using System;

namespace The_old_library
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int numberOfBooks = int.Parse(Console.ReadLine());

            int counter = 0;
            bool bookIsFound = false;

            string nextBookName = Console.ReadLine();

            while (counter < numberOfBooks)
            {
                if (nextBookName == favoriteBook)
                {
                    bookIsFound = true;
                        break;
                }
                counter++;
                nextBookName = Console.ReadLine();
            }

            if (bookIsFound == false)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numberOfBooks} books.");
            }
            else
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }


        }
    }
}
