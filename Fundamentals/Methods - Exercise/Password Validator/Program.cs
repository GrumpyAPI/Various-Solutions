using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            bool isBetweenSixAndTen = PassLengthCheck(pass);
            bool isDigitOrLetter = PassCharCheck(pass);
            bool hasMoreThanTwoDigits = PassDigitCountCheck(pass);

            if (!isBetweenSixAndTen)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isDigitOrLetter)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!hasMoreThanTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isBetweenSixAndTen && isDigitOrLetter && hasMoreThanTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool PassLengthCheck(string phrase)
        {
            return phrase.Length >= 6 && phrase.Length <= 10 ? true : false;
        }

        static bool PassCharCheck(string phrase)
        {
            char[] specialChars = new[] { '\\', '/', ':', '*', '<', '>', '|', '#', '{', '}', '%', '~', '&', '`', '!', '@', '$', '^', '(', ')', '_', '-', '=', '+', '"', '\'', '?', ',', '.' };

            bool isSpecialCharacter = false;

            for (int i = 0; i < phrase.Length; i++)
            {
                char currentChar = phrase[i];

                for (int j = 0; j < specialChars.Length; j++)
                {
                    if (currentChar == specialChars[j])
                    {
                        isSpecialCharacter = true;
                        break;
                    }
                }

                if (isSpecialCharacter)
                {
                    return false;
                }
            }
            return true;
        }

        static bool PassDigitCountCheck(string phrase)
        {
            byte digitCounter = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                char currentChar = phrase[i];

                if ("0123456789".Contains(currentChar))
                {
                    digitCounter++;
                }
            }

            if (digitCounter < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // A much simpler aproach to check if the string contains digits or letters:
        //private static bool ContainsOnlyDigitsAndLetters(string password)
        //{
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        char symbol = password[i];
        //        if (!char.IsDigit(symbol) || !char.IsLetter(symbol))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        // Another aproach to check the amount of digits:
        //private static bool CheckMinDigit(string password)
        //{
        //    int count = 0;

        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        char symbol = password[i];
        //        if (char.IsDigit(symbol))
        //        {
        //            count++;
        //        }

        //    }

        //    return count >= 2 ? true : false;
        //}
    }
}
