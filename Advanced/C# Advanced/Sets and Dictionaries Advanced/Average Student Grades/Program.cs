using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var marks = new Dictionary<string, List<decimal>>();

            int totalMarks = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalMarks; i++)
            {
                var markParts = Console.ReadLine().Split();
                var name = markParts[0];
                var mark = decimal.Parse(markParts[1]);

                if (!marks.ContainsKey(name))
                {
                    marks[name] = new List<decimal>();
                }

                marks[name].Add(mark);
            }

            foreach (var kvp in marks)
            {
                var name = kvp.Key;
                var currentMarks = kvp.Value;
                var averageMark = currentMarks.Average();

                Console.WriteLine($"{name} -> {string.Join(" ", currentMarks)} (avg: {averageMark:F2})");
            }
        }
    }
}
