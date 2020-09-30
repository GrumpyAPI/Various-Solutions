using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            byte c = byte.Parse(Console.ReadLine());
            byte d = byte.Parse(Console.ReadLine());

            for (byte firstRowFirstNum = a; firstRowFirstNum <= b; firstRowFirstNum++)
            {
                for (byte firstRowSecondNum = a; firstRowSecondNum <= b; firstRowSecondNum++)
                {
                    for (byte secondRowFirstNum = c; secondRowFirstNum <= d; secondRowFirstNum++)
                    {
                        for (byte secondRowSecondNum = c; secondRowSecondNum <= d; secondRowSecondNum++)
                        {
                            if ((firstRowFirstNum + secondRowSecondNum) == (firstRowSecondNum + secondRowFirstNum) && (firstRowFirstNum != firstRowSecondNum) && (secondRowFirstNum != secondRowSecondNum))
                            {
                                Console.WriteLine($"{firstRowFirstNum}{firstRowSecondNum}\n{secondRowFirstNum}{secondRowSecondNum}\n");
                            }
                        }
                    }
                }
            }

        }
    }
}
