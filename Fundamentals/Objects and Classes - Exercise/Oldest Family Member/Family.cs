using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oldest_Family_Member
{
    class Family
    {
        public List<Person> people { get; set; }

        public Family()
        {
            people = new List<Person>();
        }

        public void AddMember(Person member)
        {
            people.Add(member);
        }

        public Person GetOldestMember()
        {
            return people.OrderByDescending(a => a.Age).First();
        }
    }
}
