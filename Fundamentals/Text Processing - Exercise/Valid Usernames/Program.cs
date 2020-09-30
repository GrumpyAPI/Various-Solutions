using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (var username in usernames)
            {
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                if (!doesContainLNHU(username))
                {
                    continue;
                }

                if (!isRedundant(username))     // Can use "char.IsLetterOrDigit()" int the above check and completely scrap this method.
                {
                    continue;
                }

                Console.WriteLine(username);
            }
        }

        static bool doesContainLNHU(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if (!char.IsLetter(letter) && !char.IsDigit(letter) && !word.Contains("-") && !word.Contains("_"))
                {
                    return false;
                }
            }
            
            return true;
        }

        static bool isRedundant(string word)
        {
            string[] redundantSymbols = new string[] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "{", "[", "}", "]", ":", ";", "'", "\"", "<", ",", ">", ".", "?", "/", "|", "\\", "`", "~" };

            foreach (var symbol in redundantSymbols)
            {
                if (!word.Contains(symbol))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
