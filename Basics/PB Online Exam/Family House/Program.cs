using System;

namespace Family_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double electricityBill = 0;

            for (int i = 0; i < months; i++)
            {
                double currentAcDc = double.Parse(Console.ReadLine());

                electricityBill += currentAcDc;
            }

            double waterBill = months * 20;
            double netBill = months * 15;
            double otherBills = (waterBill + netBill + electricityBill) + (waterBill + netBill + electricityBill) * 0.20;
            double average = (electricityBill + waterBill + netBill + otherBills) / months;

            Console.WriteLine($"Electricity: {electricityBill:F2} lv");
            Console.WriteLine($"Water: {waterBill:F2} lv");
            Console.WriteLine($"Internet: {netBill:F2} lv");
            Console.WriteLine($"Other: {otherBills:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
