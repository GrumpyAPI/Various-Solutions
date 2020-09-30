using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1111; i < 10000; i++)
            {
                int currentNumber = i;
                int magicNumber = 0;

                for (int j = 0; j < 4; j++)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber = currentNumber / 10;

                    if (currentDigit != 0)      // Not the same as "currentDigit == 1" as the result can be 0,75 which is neither 0 nor 1, or at least it is not treated as such (not rounding the number it seems).
                    {
                        if (number % currentDigit != 0)
                        {
                            magicNumber = 0;
                            break;
                        }

                        magicNumber = i;
                    }
                    else
                    {
                        magicNumber = 0;
                        break;
                    }
                }
                if (magicNumber != 0)
                {
                    Console.Write(magicNumber + " ");
                }
            }

        }
    }
}
