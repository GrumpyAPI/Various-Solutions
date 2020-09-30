using System;

namespace Binary_Digits_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char binaryDigit = char.Parse(Console.ReadLine());

            string binaryString = "";

            while (number > 0)
            {
                binaryString += (number % 2);       // Taking the binary value one by one. Note: it takes it in reverse!
                number /= 2;
            }

            byte counter = 0;

            for (int i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] == binaryDigit)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
