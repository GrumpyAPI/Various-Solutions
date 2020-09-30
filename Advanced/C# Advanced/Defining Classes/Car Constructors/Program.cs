using System;

namespace Car_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            Console.WriteLine($"{firstCar.Make}\n{firstCar.Model}\n{firstCar.Year}\n{firstCar.FuelQuantity}\n{firstCar.FuelConsumption}\n...");
            Console.WriteLine($"{secondCar.Make}\n{secondCar.Model}\n{secondCar.Year}\n{secondCar.FuelQuantity}\n{secondCar.FuelConsumption}\n...");
            Console.WriteLine($"{thirdCar.Make}\n{thirdCar.Model}\n{thirdCar.Year}\n{thirdCar.FuelQuantity}\n{thirdCar.FuelConsumption}");
        }
    }
}
