using System;
using System.Linq;
using System.Collections.Generic;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var contest = new Dictionary<string, Dictionary<string, int>>();

            var usersTotalPoint = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("->");

                if (input[0] == "no more time")
                {
                    break;
                }

                string username = input[0];
                string contestName = input[1];
                int points = int.Parse(input[2]);
                bool itMustSum = false;

                if (!contest.ContainsKey(contestName))
                {
                    contest[contestName] = new Dictionary<string, int>() { { username, points } };
                    itMustSum = true;
                }

                if (!contest[contestName].ContainsKey(username))
                {
                    contest[contestName][username] = points;
                    itMustSum = true;
                }

                int currentPoints = contest[contestName][username];

                if (currentPoints < points)
                {
                    contest[contestName][username] = points;
                    points = points - currentPoints;
                    itMustSum = true;
                }

                if (!usersTotalPoint.ContainsKey(username))
                {
                    usersTotalPoint[username] = 0;
                }
                
                if (itMustSum)
                {
                    usersTotalPoint[username] += points;
                }
            }

            foreach (var kvp in contest)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count()} participants");

                int counter = 1;

                foreach (var item in kvp.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{counter}. {item.Key} <::> {item.Value}");
                    counter++;
                }
            }

            Console.WriteLine($"Individual standings:");

            int counterForUsers = 1;

            foreach (var kvp in usersTotalPoint
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{counterForUsers}. {kvp.Key} -> {kvp.Value}");
                counterForUsers++;
            }
        }
    }
}
