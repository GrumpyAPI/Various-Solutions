using System;

namespace Name_wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string bestName = "";       //Judge does not accepts "default" value. It says: Compile time error, so we need to use empty assignement: "".
            int bestNameSum = 0;

            while ((name = Console.ReadLine()) != "STOP")       //We are reading the name directly in the condition. Otherwise we have to include it somewhere down the code.
            {
                int nameSum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    int letter = (int)name[i];      //We are casting each individual letter in the name and saving the "int (ASCII)" value. In this case it is not actually necessary as the IDE suggests as well.
                    nameSum += letter;
                    Console.WriteLine(letter);
                }

                if (nameSum > bestNameSum)
                {
                    bestName = name;
                    bestNameSum = nameSum;
                }
            }
            Console.WriteLine($"Winner is {bestName} - {bestNameSum}!");
        }
    }
}

// If we have a space in the name. For instance: Georgi Ivanov. And we do not want to calculate the space (as it has an int value as well), we can exclude it. For instance:
//if (letter = 32)
//{
//    Continue;
//}
