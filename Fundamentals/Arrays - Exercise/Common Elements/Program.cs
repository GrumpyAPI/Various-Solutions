using System;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(" ");

            string[] secondArray = Console.ReadLine()
                .Split(" ");

            for (int i = 0; i < secondArray.Length; i++)
            {
                string element = secondArray[i];

                //if (firstArray.Contains(element))     // Shorter version.
                //{
                //    Console.WriteLine(element + " ");
                //}

                for (int j = 0; j < firstArray.Length; j++)
                {
                    string currentElement = firstArray[j];

                    if (element == currentElement)
                    {
                        Console.Write(element + " ");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
