using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(":");

                if (input[0] == "end")
                {
                    break;
                }

                string courseName = input[0];
                string studentName = input[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
            }

            courses = courses
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, p => (List<string>)p.Value.OrderBy(v => v).ToList());

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var kvp in course.Value)
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }
            // Atl solution:
            //foreach (var course in courses)
            //{
            //    Console.WriteLine($"{course.Key}: {course.Value.Count}");

            //    var list = course.Value;

            //    foreach (var item in list)
            //    {
            //        Console.WriteLine($"-- {item}");
            //    }
            //}

            // Alt solution without preOrdering the list:
            //foreach (var kvp in courses.OrderByDescending(x => x.Value.Count))
            //{
            //    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value.Count);

            //    foreach (var item in kvp.Value.OrderBy(x => x))
            //    {
            //        Console.WriteLine("-- {0}", item);
            //    }
            //}
        }
    }
}
