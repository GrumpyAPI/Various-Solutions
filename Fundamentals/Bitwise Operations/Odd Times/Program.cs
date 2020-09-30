using System;
using System.Linq;

namespace Odd_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int number = numbers[0];    // We are setting it to the firts digit in the array.

            for (int i = 1; i < numbers.Length; i++)    // We need to compare it with all numbers afterwards until the end of the array, so we are setting i to 1 (as it is the next number in the sequence).
            {
                number ^= numbers[i];   // We are XOR-ing every digit with the next one and receiving which number is repeated odd number of times.
            }
            // It works for the lab examples but in other strings of numbers sometimes it displays inacurate results. For instance: "2" even though we have "3 3 3 2 2 1" as a sequence.
            // !!Even though in this sequence this should be the odd one as it is the only digit which is an equal amount in the string of numbers.
            Console.WriteLine(number);
        }
    }
}

//XOR:
//    0 & 0 = 0
//    0 & 1 = 1
//    1 & 0 = 1
//    1 & 1 = 0