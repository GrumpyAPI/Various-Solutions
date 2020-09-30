using System;
using System.Linq;
using System.Collections.Generic;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestPasswords = new Dictionary<string, string>();

            string firstLine = Console.ReadLine();

            while (firstLine != "end of contests")
            {
                string[] tokens = firstLine.Split(':');
                string contest = tokens[0];
                string passwordForContest = tokens[1];
                contestPasswords.Add(contest, passwordForContest);
                firstLine = Console.ReadLine();
            }

            var submissions = new SortedDictionary<string, Dictionary<string, int>>();

            string secondLine = Console.ReadLine();

            while (secondLine != "end of submissions")
            {
                string[] tokens = secondLine.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (!contestPasswords.ContainsKey(contest) || contestPasswords[contest] != password)
                {
                    secondLine = Console.ReadLine();
                    continue;
                }

                if (!submissions.ContainsKey(username))
                {
                    submissions[username] = new Dictionary<string, int> { { contest, points } };
                }

                if (!submissions[username].ContainsKey(contest))
                {
                    submissions[username].Add(contest, points);
                }

                if (submissions[username][contest] < points)
                {
                    submissions[username][contest] = points;
                }

                secondLine = Console.ReadLine();
            }

            Dictionary<string, int> usersTootalPoints = new Dictionary<string, int>();
            foreach (var kvp in submissions)
            {
                usersTootalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }

            int maxPoints = usersTootalPoints
                .Values
                .Max();

            foreach (var kvp in usersTootalPoints)
            {
                if (kvp.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }

            Console.WriteLine("Ranking:");
            foreach (var kvp in submissions)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(string.Join(Environment.NewLine, kvp.Value
                    .OrderByDescending(x => x.Value)
                    .Select(a => $"#  {a.Key} -> {a.Value}")
                    ));
            }
        }
    }
}
