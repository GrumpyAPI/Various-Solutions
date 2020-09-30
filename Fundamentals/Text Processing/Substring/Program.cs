using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(key);

            while (index != -1)
            {
                text = text.Remove(index, key.Length);

                index = text.IndexOf(key);
            }

            Console.WriteLine(text);

            //string result = text.Replace(key, string.Empty);  // Simpler solution. However in the case "ice" "kicegiciceeb" it is not removing all instances as it seems to be going once through the string.

            //Console.WriteLine(result);
        }
    }
}
