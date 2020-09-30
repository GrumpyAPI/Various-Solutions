using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                string[] studentArgs = Console.ReadLine().Split();

                string firstName = studentArgs[0];
                string lastName = studentArgs[1];
                string grade = studentArgs[2];

                Student student = new Student(firstName, lastName, grade);

                //Student student1 = new Student()    // In order for this {default method} to work we need the empty constructor, otherwise it will always ask us for parameters.
                //{
                //    FirstName = firstName,
                //    LastName = lastName,
                //    Grade = grade
                //};

                // We can also use the following syntax but we still need the empty constructor, unless we don't have a constructor that we have created. This will still work for default.
                //Student student = new Student();
                //student.FirstName = firstName;
                //student.LastName = lastName;
                //student.Grade = grade;

                students.Add(student);
            }

            List<Student> sortedStudents = students
                .OrderByDescending(x => x.Grade)
                .ToList();

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade}");
            }
        }
    }
}
