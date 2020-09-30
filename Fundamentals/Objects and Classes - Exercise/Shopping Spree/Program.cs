using System;
using System.Collections.Generic;

namespace Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInitial = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            string[] productsInitial = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < peopleInitial.Length; i += 2)
            {
                string name = peopleInitial[i];
                int money = int.Parse(peopleInitial[i + 1]);

                Person person = new Person(name, money);

                people.Add(person);
            }

            for (int i = 0; i < productsInitial.Length; i += 2)
            {
                string itemName = productsInitial[i];
                int cost = int.Parse(productsInitial[i + 1]);

                Product product = new Product(itemName, cost);

                products.Add(product);
            }

            string input = "";

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split();

                string personName = tokens[0];
                string itemName = tokens[1];

                foreach (var person in people)
                {
                    if (person.Name == personName)
                    {
                        foreach (var product in products)
                        {
                            if (product.Name == itemName)
                            {
                                if (person.Money >= product.Cost)
                                {
                                    person.Money -= product.Cost;
                                    person.products.Add(itemName);

                                    Console.WriteLine($"{personName} bought {itemName}");
                                }
                                else
                                {
                                    Console.WriteLine($"{personName} can't affort {itemName}");
                                }
                            }
                        }
                    }
                }
            }

            foreach (var person in people)
            {
                if (person.products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.products)}");
                }
            }
        }
    }
}
