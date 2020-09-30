using System;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder();

            int inMind = 0;

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                int lastDigit = int.Parse(numberAsString[i].ToString());

                int result = lastDigit * multiplier;

                builder.Append(result % 10 + inMind);

                inMind = result / 10;
            }

            if (inMind != 0)
            {
                builder.Append(inMind);
            }

            string resultNumber = string.Join("", builder.ToString().Reverse()).TrimStart('0');

            if (resultNumber == string.Empty)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(resultNumber);
            }
        }
    }
}
