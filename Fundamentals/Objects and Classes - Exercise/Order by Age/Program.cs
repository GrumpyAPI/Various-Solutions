using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" ");

                string name = tokens[0];
                string id = tokens[1];
                string age = tokens[2];

                Person person = new Person(name, id, age);

                people.Add(person);

                input = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}
