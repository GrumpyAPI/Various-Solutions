using System;
using System.Collections.Generic;

namespace Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < peopleNumber; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                Person person = new Person(tokens[0], int.Parse(tokens[1]));

                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
