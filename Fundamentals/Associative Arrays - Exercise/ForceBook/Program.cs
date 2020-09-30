using System;
using System.Linq;
using System.Collections.Generic;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideMembers = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] splitOutput = input.Split(" | ");
                    string side = splitOutput[0];
                    string memberName = splitOutput[1];

                    if (!sideMembers.ContainsKey(side))
                    {
                        sideMembers[side] = new List<string>();
                    }

                    bool memberExists = false;

                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Contains(memberName))
                        {
                            memberExists = true;
                            break;
                        }
                    }

                    if (!sideMembers[side].Contains(memberName) && !memberExists)
                    {
                        sideMembers[side].Add(memberName);
                    }
                }
                else
                {
                    string[] splitInput = input.Split(" -> ");
                    string memberName = splitInput[0];
                    string side = splitInput[1];

                    bool memberExists = false;
                    string currentSide = "";

                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Contains(memberName))
                        {
                            memberExists = true;
                            currentSide = kvp.Key;
                            break;
                        }
                    }

                    if (memberExists)
                    {
                        sideMembers[currentSide].Remove(memberName);
                    }

                    if (!sideMembers.ContainsKey(side))
                    {
                        sideMembers[side] = new List<string>();
                    }

                    if (!sideMembers[side].Contains(memberName))
                    {
                        sideMembers[side].Add(memberName);
                    }

                    Console.WriteLine($"{memberName} joins the {side} side!");
                }

                input = Console.ReadLine();
            }

            sideMembers = sideMembers
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sideMembers)
            {
                string sideName = kvp.Key;
                List<string> sidesMembers = kvp.Value;

                sidesMembers.Sort();

                Console.WriteLine($"Side: {sideName}, Members: {sidesMembers.Count}");

                foreach (var member in sidesMembers)
                {
                    Console.WriteLine($"! {member}");
                }
            }
        }
    }
}
