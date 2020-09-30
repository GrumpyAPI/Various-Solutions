using System;

namespace p_th_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            string binaryString = "";

            while (number > 0)
            {
                binaryString += (number % 2);
                number /= 2;
            }
            // Technically there is no need to reverse it as we can simply use "binaryString[position]" and it will still be accurate but we are using it for reality purposes.
            binaryString = Reverse(binaryString);

            if (((binaryString.Length - 1) - position) < 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(binaryString[(binaryString.Length - 1) - position]);
            }
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
