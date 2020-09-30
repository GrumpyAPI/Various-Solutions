using System;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfStrings = byte.Parse(Console.ReadLine());
            int[] convertedNames = new int[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                string name = Console.ReadLine();

                char[] nameArray = name.ToCharArray();

                int vowels = 0;
                int consonants = 0;

                for (int j = 0; j < name.Length; j++)
                {
                    char currentChar = nameArray[j];

                    if ("aeiouAEIOU".Contains(currentChar))
                    {
                        vowels += currentChar;
                    }
                    else
                    {
                        consonants += currentChar;
                    }

                }

                int currentName = (vowels * name.Length) + (consonants / name.Length);

                convertedNames[i] = currentName;
            }

            for (int i = 0; i < numberOfStrings; i++)
            {

                for (int j = 0; j < numberOfStrings - 1; j++)       // Sorting the items in the array in ascending order.
                {
                    for (int k = j + 1; k < numberOfStrings; k++)
                    {
                        if (convertedNames[j] > convertedNames[k])
                        {
                            int temp = convertedNames[j];
                            convertedNames[j] = convertedNames[k];
                            convertedNames[k] = temp;
                        }
                    }
                }
                Console.WriteLine(convertedNames[i]);
            }
        }
    }
}
