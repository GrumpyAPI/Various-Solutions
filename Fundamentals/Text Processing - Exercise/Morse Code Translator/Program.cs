using System;
using System.Collections.Generic;
using System.Linq;

namespace Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            var morseCode = new Dictionary<string, char>();

            morseCode[".-"] = 'A';
            morseCode["-..."] = 'B';
            morseCode["-.-."] = 'C';
            morseCode["-.."] = 'D';
            morseCode["."] = 'E';
            morseCode["..-."] = 'F';
            morseCode["--."] = 'G';
            morseCode["...."] = 'H';
            morseCode[".."] = 'I';
            morseCode[".---"] = 'J';
            morseCode["-.-"] = 'K';
            morseCode[".-.."] = 'L';
            morseCode["--"] = 'M';
            morseCode["-."] = 'N';
            morseCode["---"] = 'O';
            morseCode[".--."] = 'P';
            morseCode["--.-"] = 'Q';
            morseCode[".-."] = 'R';
            morseCode["..."] = 'S';
            morseCode["-"] = 'T';
            morseCode["..-"] = 'U';
            morseCode["...-"] = 'V';
            morseCode[".--"] = 'W';
            morseCode["-..-"] = 'X';
            morseCode["-.--"] = 'Y';
            morseCode["--.."] = 'Z';
            morseCode["-----"] = '0';
            morseCode[".----"] = '1';
            morseCode["..---"] = '2';
            morseCode["...--"] = '3';
            morseCode["....-"] = '4';
            morseCode["....."] = '5';
            morseCode["-...."] = '6';
            morseCode["--..."] = '7';
            morseCode["---.."] = '8';
            morseCode["----."] = '9';
            morseCode[".-..."] = '&';
            morseCode[".----."] = '\'';
            morseCode[".--.-."] = '@';
            morseCode["-.--.-"] = ')';
            morseCode["-.--."] = '(';
            morseCode["---..."] = ':';
            morseCode["--..--"] = ',';
            morseCode["-...-"] = '=';
            morseCode["-.-.--"] = '!';
            morseCode[".-.-.-"] = '.';
            morseCode["-....-"] = '-';
            morseCode[".-.-."] = '+';
            morseCode[".-..-."] = '"';
            morseCode["..--.."] = '?';
            morseCode["-..-."] = '/';

            Console.Write("Choose between 'Code' or 'Text':");
            string option = Console.ReadLine();

            string decodedMessage = string.Empty;

            if (option == "Code")
            {
                Console.WriteLine("You need to type every letter with a 'space' afterwards and seperate words with '|'.");
                string[] code = Console.ReadLine().Split(' ');

                for (int i = 0; i < code.Length; i++)
                {
                    foreach (var kvp in morseCode)
                    {
                        if (code[i] == kvp.Key)
                        {
                            decodedMessage += kvp.Value;
                        }

                    }

                    if (code[i] == "|")
                    {
                        decodedMessage += " ";
                    }
                }
            }
            else
            {
                Console.WriteLine("You need to type in capitals.");

                string text = Console.ReadLine();

                for (int i = 0; i < text.Length; i++)
                {
                    foreach (var kvp in morseCode)
                    {
                        if (text[i] == kvp.Value)
                        {
                            decodedMessage += kvp.Key + " ";
                        }
                    }

                    if (text[i] == ' ')
                    {
                        decodedMessage += "|";
                    }
                }
            }

            Console.WriteLine(decodedMessage);
        }
    }
}
