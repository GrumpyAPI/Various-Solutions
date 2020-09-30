using System;
using System.Linq;
using System.Collections.Generic;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var contest = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }

                string username = "";
                string position = "";
                int points = 0;
                string player1 = "";
                string player2 = "";

                if (input.Contains("vs"))
                {
                    string[] tokens = input.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    player1 = tokens[0].Trim(); // Trimming an extra blank space after, before or at both ends in each string as those prevent the following 'if' statement and other operations from working.
                    player2 = tokens[2].Trim();

                    var list = contest.Keys;

                    if (list.Contains(player1) && list.Contains(player2))
                    {
                        var result = HaveCommonPositions(contest, player1, player2);

                        if (result.Item1 == "Yes")
                        {
                            if (contest[player1][result.Item2] > contest[player2][result.Item2])
                            {
                                contest.Remove(player2);
                            }
                            else if (contest[player1][result.Item2] < contest[player2][result.Item2])
                            {
                                contest.Remove(player1);
                            }
                        }
                    }
                }
                else
                {
                    string[] tokens = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                    username = tokens[0].Trim();
                    position = tokens[1].Trim();
                    points = int.Parse(tokens[2]);

                    if (!contest.ContainsKey(username))
                    {
                        contest[username] = new Dictionary<string, int>() { { position, points } };
                    }

                    if (!contest[username].ContainsKey(position))
                    {
                        contest[username][position] = points;
                    }

                    if (contest[username][position] < points)
                    {
                        contest[username][position] = points;
                    }
                }
            }

            foreach (var kvp in contest.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key)) // Ordering needs to be done in the expression as you have the entire dictionary there.
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} skill");    // Here are only single items. It may work for nested dictionaries but in the next foreach is just a single one and you can sort single items (duuh).

                foreach (var item in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }

        private static Tuple<string, string> HaveCommonPositions(Dictionary<string, Dictionary<string, int>> contest, string player1, string player2)
        {
            foreach (var position1 in contest[player1])
            {
                foreach (var position2 in contest[player2])
                {
                    if (position1.Key == position2.Key)
                    {
                        return Tuple.Create("Yes", position1.Key);
                    }
                }
            }
            return Tuple.Create("No", "");
        }
    }
}
