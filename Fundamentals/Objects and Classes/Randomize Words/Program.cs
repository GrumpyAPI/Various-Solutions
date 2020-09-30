using System;
using System.Linq;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsArray = Console.ReadLine().Split().ToArray();

            Random rnd = new Random();

            for (int i = 0; i < wordsArray.Length; i++)
            {
                int randomIndex = rnd.Next(0, wordsArray.Length);   // MinValue is inclusive, MaxValue is exclusive. i.e. it generates a number up to wordsArray.length - 1.

                // Swapping their places.
                string randomElement = wordsArray[randomIndex];

                wordsArray[randomIndex] = wordsArray[i];
                wordsArray[i] = randomElement;

                // SoftUni example is with 2 variables:

                //string randomElement = wordsArray[randomIndex];
                //string element = wordsArray[i];

                //wordsArray[randomIndex] = element;
                //wordsArray[i] = randomElement;
            }

            for (int i = 0; i < wordsArray.Length; i++)
            {
                Console.WriteLine(wordsArray[i]);
            }
        }
    }
}
