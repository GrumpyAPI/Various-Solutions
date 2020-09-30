using System;

namespace Car_Engine_and_Tires
{
    public class Car
    {
        private string model;
        private int year;

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 1992;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption) 
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        // That way we can skip the fields as C# creates them by default to save the values there and we can initialize only the properties (unless we need validation):
        public string Make { get; set; }

        // With validation:
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("Car model needs to be at least 2 symbols.");
                }

                this.model = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;   // Need to refer to the field and not the property: i.e (year and not Year).
            }
            set
            {
                var maxYear = DateTime.Now.Year;
                if (value < 1950 || value > maxYear)
                {
                    throw new ArgumentException($"Year needs to be between 1950 and {maxYear}");
                }

                this.year = value;
            }
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        // We can make the getters and setters 'public' or 'private' (most commonly it is private):
        //public double FuelConsumption { get; private set; }
    }
}
