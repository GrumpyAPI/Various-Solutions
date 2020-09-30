using System;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestPerformerSum = int.Parse(Console.ReadLine());
            string group;
            int sum = 0;
            int guests = 0;

            while ((group = Console.ReadLine()) != "The restaurant is full")
            {
                int stringToInt = Convert.ToInt32(group);

                if (stringToInt >= 5)
                {
                    sum += stringToInt * 70;
                }
                else
                {
                    sum += stringToInt * 100;
                }

                guests += stringToInt;
            }

            int totalSum = sum - guestPerformerSum;

            if (sum < guestPerformerSum)
            {
                Console.WriteLine($"You have {guests} guests and {sum} leva income, but no singer.");
            }
            else
            {
                Console.WriteLine($"You have {guests} guests and {totalSum} leva left.");
            }
        }
    }
}
