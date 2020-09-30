using System;

namespace Bit_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            string binaryString = "";

            while (number > 0)
            {
                binaryString += (number % 2);
                number /= 2;
            }

            binaryString = binaryString.Insert(position, "0");  // Obviously it is not the position of the index, i.e. we are not counting from 0.
            binaryString = binaryString.Remove(position + 1, 1);

            long binaryInt = long.Parse(Reverse(binaryString));

            int result = BinaryToDecimal(binaryInt, binaryString);

            Console.WriteLine(result);
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static int BinaryToDecimal(long a, string b)
        {
            int result = 0;

            for (int i = 0; i < b.Length; i++)
            {
                int currentDigit = (int)(a % 10);
                a /= 10;
                result += currentDigit * (int)Math.Pow(2, i);
            }

            return result;
        }
    }
}
