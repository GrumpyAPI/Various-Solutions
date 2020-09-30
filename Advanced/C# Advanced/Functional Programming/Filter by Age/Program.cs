using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_Age
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < totalPeople; i++)
            {
                var currentPerson = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var person = new Person
                {
                    Name = currentPerson[0],
                    Age = int.Parse(currentPerson[1])
                };

                people.Add(person);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, bool> filterPredicate;

            if (condition == "older")
            {
                filterPredicate = p => p.Age >= age;
            }
            else
            {
                filterPredicate = p => p.Age < age;
            }

            string format = Console.ReadLine();

            Func<Person, string> selectFunc;

            if (format == "name age")
            {
                selectFunc = p => $"{p.Name} - {p.Age}";
            }
            else if (format == "name")
            {
                selectFunc = p => $"{p.Name}";
            }
            else        // If we use another 'else if' for the 'age', the 'Select' function below errors as we are using a function (selectFunc) that hasn't been assigned a value as we are not covering all possibilities without the 'else'.
            {
                selectFunc = p => $"{p.Age}";
            }

            people.Where(filterPredicate).Select(selectFunc).ToList().ForEach(Console.WriteLine);
        }
    }
}
