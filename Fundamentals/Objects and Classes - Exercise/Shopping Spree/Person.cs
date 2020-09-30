using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Spree
{
    class Person
    {
        public List<string> products;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            products = new List<string>();
        }

        public string Name { get; set; }

        public int Money { get; set; }
    }
}
