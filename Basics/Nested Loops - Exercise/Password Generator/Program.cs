using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberN = byte.Parse(Console.ReadLine());
            byte numberL = byte.Parse(Console.ReadLine());

            for (byte i = 1; i < numberN; i++)
            {
                for (byte j = 1; j < numberN; j++)
                {
                    for (char k = 'a'; k < ('a' + numberL); k++)
                    {
                        for (char l = 'a'; l < ('a' + numberL); l++)
                        {
                            for (byte m = 1; m <= numberN; m++)
                            {
                                if ((m > i) && (m > j))
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)l}{m} ");
                                }

                            }
                        }
                    }
                }
            }

        }
    }
}
