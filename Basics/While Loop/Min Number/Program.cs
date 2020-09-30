using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int lowestNumber = int.MaxValue;
            int i = 1;

            while (i <= numberCount)
            {
                int number = int.Parse(Console.ReadLine());
                if (lowestNumber >= number)
                {
                    lowestNumber = number;
                }
                i++;
            }

            Console.WriteLine(lowestNumber);
        }
    }
}
