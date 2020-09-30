using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubicMeters = double.Parse(Console.ReadLine());

            double price = cubicMeters * 7.61;
            double discount = price * 0.18;
            double finalPrice = price - discount;

            Console.Write("The final price is: ");
            Console.Write("{0:F2}", finalPrice);
            Console.WriteLine(" lv.");
            Console.Write("The discount is: ", "{0:F2}", discount);
            Console.Write("{0:F2}", discount);
            Console.WriteLine(" lv.");
        }
    }
}
