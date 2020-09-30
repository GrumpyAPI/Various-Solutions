using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();
            var userFollowers = new Dictionary<string, HashSet<string>>();
            var userFollowings = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                string[] splitInput = input.Split();

                if (splitInput.Length == 4)
                {
                    string username = splitInput[0];

                    if (!usernames.Contains(username))
                    {
                        usernames.Add(username);
                        userFollowers.Add(username, new HashSet<string>());
                        userFollowings[username] = new HashSet<string>();
                    }
                }
                else
                {
                    string heFollows = splitInput[0];
                    string followed = splitInput[2];

                    if (usernames.Contains(heFollows) && usernames.Contains(followed) && heFollows != followed)
                    {
                        userFollowers[followed].Add(heFollows);
                        userFollowings[heFollows].Add(followed);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has total of {usernames.Count} vloggers in its logs.");

            var topUser = userFollowers.OrderByDescending(x => x.Value.Count).ThenBy(x => userFollowings[x.Key].Count()).FirstOrDefault();

            Console.WriteLine($"1. {topUser.Key} : {topUser.Value.Count} followers, {userFollowings[topUser.Key].Count} following");

            foreach (var username in topUser.Value.OrderBy(a => a))
            {
                Console.WriteLine($"*  {username}");
            }

            int count = 2;

            foreach (var kvp in userFollowers.Where(x => x.Key != topUser.Key).OrderByDescending(x => x.Value.Count).ThenBy(x => userFollowings[x.Key].Count()))
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value.Count} followers, {userFollowings[kvp.Key].Count} following");

                count++;
            }
        }
    }
}
