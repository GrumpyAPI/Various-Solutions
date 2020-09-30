using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            if (type == "int")
            {
                int number = int.Parse(input);

                DataType(number);
            }
            else if (type == "real")
            {
                double number = double.Parse(input);

                DataType(number);
            }
            else if (type == "string")
            {
                DataType(input);
            }
        }

        static void DataType(int a)
        {
            int result = a * 2;

            Console.WriteLine(result);
        }

        static void DataType(double a)
        {
            double result = a * 1.5;

            Console.WriteLine($"{result:F2}");
        }

        static void DataType(string a)
        {
            Console.WriteLine("$" + a + "$");
        }
    }
}
