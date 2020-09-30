using System;

namespace Car_Engine_and_Tires
{
    class Program
    {
        static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
                new Tire(1 ,2.5),
                new Tire(1 ,2.1),
                new Tire(2 ,0.5),
                new Tire(2 ,2.3)
            };

            var engine = new Engine(560, 6300);

            var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nFuel: {car.FuelQuantity}\nConsumption: {car.FuelConsumption}\nHP: {car.Engine.HorsePower}\nCC: {car.Engine.CubicCapacity}\nTyres: {car.Tires.Length}");
            Console.WriteLine($"Year: {car.Tires[0].Year} - Pressure: {car.Tires[0].Pressure}");
            Console.WriteLine($"Year: {car.Tires[1].Year} - Pressure: {car.Tires[1].Pressure}");
            Console.WriteLine($"Year: {car.Tires[2].Year} - Pressure: {car.Tires[2].Pressure}");
            Console.WriteLine($"Year: {car.Tires[3].Year} - Pressure: {car.Tires[3].Pressure}");
        }
    }
}
