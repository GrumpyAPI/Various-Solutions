using System;
using System.Linq;
using System.Collections.Generic;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mainStringList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> command = Console.ReadLine()
                .Split()
                .ToList();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex > mainStringList.Count - 1)
                    {
                        startIndex = mainStringList.Count - 2;
                    }
                    if (endIndex < 0)
                    {
                        endIndex = 0;
                    }
                    else if (endIndex > mainStringList.Count - 1)
                    {
                        endIndex = mainStringList.Count - 1;
                    }

                    List<string> tempList = new List<string>();

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        tempList.Add(mainStringList[i]);
                    }

                    mainStringList[startIndex] = string.Join("", tempList);

                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        mainStringList.RemoveAt(startIndex + 1);
                    }
                }
                else if (command[0] == "divide")
                {
                    List<string> tempList = new List<string>();

                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    string toDivide = mainStringList[index];
                    int partLength = toDivide.Length / partitions;
                    int additionalPartLength = toDivide.Length % partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            partLength += additionalPartLength;
                        }

                        tempList.Add(toDivide.Substring(0, partLength));
                        toDivide = toDivide.Remove(0, partLength);
                    }

                    mainStringList.RemoveAt(index);
                    mainStringList.InsertRange(index, tempList);
                }

                command = Console.ReadLine()
                .Split()
                .ToList();
            }

            Console.WriteLine(string.Join(" ", mainStringList));
        }
    }
}
