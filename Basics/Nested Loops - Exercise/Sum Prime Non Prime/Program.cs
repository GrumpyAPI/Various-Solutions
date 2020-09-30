using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            int primeSum = 0;
            int compositeSum = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                if (number == 1 || number == 4)
                {
                    compositeSum += number;
                    continue;
                }

                bool isComposite = false;

                for (byte i = 3; i < number && i < 10; i += 2)
                {
                    if (number % i == 0)
                    {
                        compositeSum += number;
                        isComposite = true;
                        break;
                    }
                }

                if (isComposite)
                {
                    continue;
                }
                else
                {
                    primeSum += number;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}\nSum of all non prime numbers is: {compositeSum}");
        }
    }
}
