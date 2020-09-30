﻿using System;

namespace Car_Extension
{
    class Car
    {
        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;

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

        // Methods:
        public void Drive(double distance)
        {
            var canContinue = this.FuelQuantity - distance * this.FuelConsumption >= 0;

            if (canContinue)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                throw new Exception("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";

            // Another approach:
            //var result = new StringBuilder();
            //result.AppendLine($"Make: {this.Make}");
            //result.AppendLine($"Model: {this.Model}");
            //result.AppendLine($"Year: {this.Year}");
            //result.Append($"Fuel: {this.FuelQuantity:F2}L");
            //return result.ToString();
        }
    }
}
