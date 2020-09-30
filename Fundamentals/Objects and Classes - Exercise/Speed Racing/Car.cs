using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Racing
{
    class Car
    {
        public Car(string model, double fuel, double fuelConsumption)
        {
            Model = model;
            Fuel = fuel;
            FuelPerKm = fuelConsumption;
            TravelDistance = 0;
        }

        public void Drive(double travelDistance)
        {
            if (travelDistance * FuelPerKm <= Fuel)
            {
                TravelDistance += travelDistance;
                Fuel -= travelDistance * FuelPerKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public string Model { get; set; }

        public double Fuel { get; set; }

        public double FuelPerKm { get; set; }

        public double TravelDistance { get; set; }
    }
}
