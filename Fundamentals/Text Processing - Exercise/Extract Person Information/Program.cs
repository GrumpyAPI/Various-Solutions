using System;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentLine = Console.ReadLine();

                int indexBeforeTheName = currentLine.IndexOf('@');
                int indexAfterTheName = currentLine.IndexOf('|');

                string name = currentLine.Substring(indexBeforeTheName + 1, (indexAfterTheName - 1) - indexBeforeTheName);

                int indexBeforeTheAge = currentLine.IndexOf('#');
                int indexAfterTheAge = currentLine.IndexOf('*');

                string age = currentLine.Substring(indexBeforeTheAge + 1, (indexAfterTheAge - 1) - indexBeforeTheAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
