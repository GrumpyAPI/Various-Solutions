using System;
using System.Linq;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuests = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();
            guests.Add(null);

            for (int i = 0; i < numberOfGuests; i++)
            {
                List<string> guestsIntentions = Console.ReadLine()
                .Split()
                .ToList();

                if (guestsIntentions[2] == "going!")
                {
                    CheckAddToList(guests, guestsIntentions);
                }
                else if (guestsIntentions[2] == "not")
                {
                    CheckRemoveFromList(guests, guestsIntentions);
                }
            }

            guests.RemoveAt(0);

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }

        static void CheckAddToList(List<string> guests, List<string> guestsIntentions)
        {
            bool isInList = false;

            for (int j = 0; j < guests.Count; j++)
            {
                if (guests[j] == guestsIntentions[0])
                {
                    isInList = true;
                    Console.WriteLine($"{guestsIntentions[0]} is already in the list!");
                    break;
                }
            }

            if (!isInList)
            {
                guests.Add(guestsIntentions[0]);
            }
        }

        static void CheckRemoveFromList(List<string> guests, List<string> guestsIntentions)
        {
            bool isInList = false;

            for (int j = 0; j < guests.Count; j++)
            {
                if (guests[j] == guestsIntentions[0])
                {
                    isInList = true;
                    guests.Remove(guestsIntentions[0]);
                    break;
                }
            }

            if (!isInList)
            {
                Console.WriteLine($"{guestsIntentions[0]} is not in the list!");
            }
        }
    }
}
