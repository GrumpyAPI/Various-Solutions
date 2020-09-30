using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            string line = Console.ReadLine();

            while (line != "PARTY")
            {
                char vipChar = line[0];

                if (char.IsDigit(vipChar))
                {
                    vipGuests.Add(line);
                }
                else
                {
                    regularGuests.Add(line);
                }

                line = Console.ReadLine();
            }

            string guest = Console.ReadLine();

            while (guest != "END")
            {
                if (vipGuests.Contains(guest))
                {
                    vipGuests.Remove(guest);
                }
                else if (regularGuests.Contains(guest))
                {
                    regularGuests.Remove(guest);
                }

                guest = Console.ReadLine();
            }

            int guestCount = vipGuests.Count + regularGuests.Count;

            Console.WriteLine(guestCount);

            foreach (var vip in vipGuests)
            {
                Console.WriteLine(vip);
            }

            foreach (var reg in regularGuests)
            {
                Console.WriteLine(reg);
            }
        }
    }
}
