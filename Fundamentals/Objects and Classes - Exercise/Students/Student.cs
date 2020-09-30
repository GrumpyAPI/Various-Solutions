using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Student
    {
        public Student(string firstName, string lastName, string grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public Student()    // We are overloading the constructor so that we can use both variants of creating an object.
        {
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Grade { get; set; }
    }
}
