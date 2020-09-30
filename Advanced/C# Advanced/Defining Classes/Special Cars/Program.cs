using System;
using System.Collections.Generic;
using System.Linq;

namespace Special_Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> enginesList = new List<Engine>();
            List<Tire[]> tiresList = new List<Tire[]>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "No more tires")
                {
                    break;
                }

                string[] tires = line.Split();
                int tireIndex = 0;
                Tire[] tireSet = new Tire[4];

                for (int i = 0; i < 8; i += 2)
                {
                    int year = int.Parse(tires[i]);
                    double pressure = double.Parse(tires[i + 1]);

                    Tire tire = new Tire(year, pressure);
                    tireSet[tireIndex] = tire;
                    tireIndex++;
                }

                tiresList.Add(tireSet);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Engines done")
                {
                    break;
                }

                double[] engines = line.Split().Select(double.Parse).ToArray();

                Engine engine = new Engine((int)engines[0], engines[1]);
                enginesList.Add(engine);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Show special")
                {
                    break;
                }

                string[] carSpecs = line.Split();

                string make = carSpecs[0];
                string model = carSpecs[1];
                int year = int.Parse(carSpecs[2]);
                double fuelQuantity = double.Parse(carSpecs[3]);
                double fuelConsumption = double.Parse(carSpecs[4]);
                int engineIndex = int.Parse(carSpecs[5]);
                int tiresIndex = int.Parse(carSpecs[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, enginesList[engineIndex], tiresList[tiresIndex]);

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                if (car.Year >= 2017)
                {
                    if (car.Engine.HorsePower > 330)
                    {
                        var presssureSum = (car.Tires[0].Pressure) + (car.Tires[1].Pressure) + (car.Tires[2].Pressure) + (car.Tires[3].Pressure);

                        if (presssureSum >= 9 && presssureSum <= 10)
                        {
                            car.FuelQuantity -= car.FuelConsumption / 5;    // Since we need 20km and 100 / 20 = 5

                            var make = car.Make;
                            var model = car.Model;
                            var year = car.Year;
                            var HP = car.Engine.HorsePower;
                            var fuelQuantity = car.FuelQuantity;

                            Console.WriteLine($"Make: {make}\nModel: {model}\nYear: {year}\nHorsePower: {HP}\nFuelQuantity: {fuelQuantity}");
                        }
                    }
                }
            }
        }
    }
}
