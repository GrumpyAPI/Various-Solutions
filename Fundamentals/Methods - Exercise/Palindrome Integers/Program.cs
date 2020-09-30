using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while ((input = Console.ReadLine()) != "END")
            {
                bool result = IsPalindrome(input);

                Console.WriteLine(result);
            }
        }

        static bool IsPalindrome(string a)
        {
            int j = (a.Length - 1);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == a[j])
                {
                    j--;
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
