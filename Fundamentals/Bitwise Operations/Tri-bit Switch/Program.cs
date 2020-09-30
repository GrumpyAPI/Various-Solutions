using System;

namespace Tri_bit_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            long mask = 7 << p;
            long result = n ^ mask;

            Console.WriteLine(result);
        }
    }
}

/*
Example:
    n =    1-001-1010010
    mask = 0-111-0000000  we take the number 7 as it consists only of 1s, i.e. "111" and we shift it left p times. In this case 7 times.
               ^
               |
    p =        7th. position (8th index)
    XOR =  1-110-1010010  <-- result

XOR:
    0 & 0 = 0
    0 & 1 = 1
    1 & 0 = 1
    1 & 1 = 0
*/
