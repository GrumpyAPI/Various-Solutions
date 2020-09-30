using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string justNumbers = string.Empty;

            List<string> textString = new List<string>();
            List<int> numbersString = new List<int>();

            for (int i = 0; i < input.Length; i++)      // Taking the digits from the string, putting them in a separate one and deleting them from the original string.
            {
                if (Char.IsDigit(input[i]))
                {
                    numbersString.Add(int.Parse(input[i].ToString()));      // Need to have ".ToString()" as otherwise it displays an error: "cannot convert from 'char' to 'system.readonlyspan<char>'".
                }
                else
                {
                    textString.Add(input[i].ToString());
                }
            }

            List<int> skipList = new List<int>();
            List<int> takeList = new List<int>();

            for (int i = 0; i < numbersString.Count; i++)       // Splitting the numbers list into skip and take lists.
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersString[i]);
                }
                else
                {
                    skipList.Add(numbersString[i]);
                }
            }

            List<string> decryptedMessage = new List<string>();

            int countIndex = 0;
            // As it turns out we are never meant to restart the indexing if we go outside the list as we go through the string only once. Thus the commented part of the solution is inaccurate.
            for (int i = 0; i < takeList.Count; i++)        // Adding the necessary chars to the decrypted message list.
            {
                if (takeList[i] > 0)
                {
                    for (int j = 0; j < takeList[i]; j++)
                    {
                        if (countIndex == textString.Count)
                        {
                            //countIndex = 0;
                            break;
                        }

                        decryptedMessage.Add(textString[countIndex]);
                        countIndex++;
                    }
                }
                
                if (skipList[i] > 0)
                {
                    countIndex = countIndex + skipList[i];

                    //if (countIndex >= textString.Count)
                    //{
                    //    countIndex = countIndex - textString.Count;
                    //}
                }
            }

            Console.WriteLine(string.Join("", decryptedMessage));
        }
    }
}


// This is another approach:
//using System;
//using System.Text;
//using System.Linq;
//using System.Collections.Generic;

// namespace Take_Skip_Rope
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string word = Console.ReadLine();
//            List<int> numbers = new List<int>();
//            List<int> takeList = new List<int>();
//            List<int> skipList = new List<int>();
//            StringBuilder result = new StringBuilder();
//            List<string> nonNumbers = new List<string>();

//            for (int i = 0; i < word.Length; i++)
//            {
//                if (char.IsDigit(word[i]))
//                {
//                    numbers.Add(int.Parse(word[i].ToString()));
//                }
//                else
//                {
//                    nonNumbers.Add(word[i].ToString());
//                }

//            }
//            for (int i = 0; i < numbers.Count; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    takeList.Add(numbers[i]);
//                }
//                else
//                {
//                    skipList.Add(numbers[i]);
//                }
//            }

//            int indexForSkip = 0;

//            for (int i = 0; i < takeList.Count; i++)
//            {
//                List<string> temp = new List<string>(nonNumbers);

//                temp = temp.Skip(indexForSkip).Take(takeList[i]).ToList();

//                result.Append(string.Join("", temp));

//                indexForSkip += takeList[i] + skipList[i];
//            }

//            Console.WriteLine(result.ToString());
//        }
//    }
//}