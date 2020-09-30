using System;

namespace Car_Constructors
{
    public class Car
    {
        // Constructors:
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 1992;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            :this()     // Calls for the default values from the first constructor for the remaining params.
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            :this(make, model, year)     // Calls for the second constructor.
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        // Fields:
        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;

        // Properties:
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
    }
}
