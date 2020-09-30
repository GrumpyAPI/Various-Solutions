using System;
using System.Linq;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split();

            for (int i = 0; i < texts.Length; i++)
            {
                Console.Write($"{texts[texts.Length - i - 1]} ");
            }

            //string[] texts = Console.ReadLine().Split();

            //string[] result = new string[texts.Length];

            //for (int i = 0; i < texts.Length / 2; i++)
            //{
            //    string first = texts[i];
            //    string last = texts[texts.Length - i - 1];

            //    texts[i] = last;
            //    texts[texts.Length - i - 1] = first;
            //}

            //for (int i = 0; i < texts.Length; i++)
            //{
            //    Console.WriteLine(texts[i]);
            //}
        }
    }
}
