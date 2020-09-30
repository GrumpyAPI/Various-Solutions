using System;
using System.Collections.Generic;
using System.Text;

namespace Order_by_Age
{
    class Person
    {
        public Person(string name, string id, string age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public string Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
