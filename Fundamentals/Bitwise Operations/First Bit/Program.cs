using System;

namespace First_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number >>= 1;   // Make the shift before converting to binary as the othe way arround does not seem to be working.

            string binaryString = "";

            while (number > 0)
            {
                binaryString += (number % 2);
                number /= 2;
            }

            // No need to reverse as we need the "0" index and it is easier to leave it as it is. Otherwise we have to use "binaryString[binarystring.length - 1]"

            Console.WriteLine(binaryString[0]);

            // SoftUni solution:
            //int number = int.Parse(Console.ReadLine());

            //int shiftedValue = number >> 1;

            //Console.WriteLine(shiftedValue & 1);
        }
    }
}
