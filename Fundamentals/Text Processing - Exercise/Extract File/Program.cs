using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            string[] extension = path.Split(".");
            string[] fileName = extension[0].Split("\\");

            Console.WriteLine($"File name: {fileName[fileName.Length - 1]}");
            Console.WriteLine($"File extension: {extension[1]}");
        }
    }
}
