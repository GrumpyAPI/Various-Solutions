using System;

namespace Special_Cars
{
    class Tire
    {
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year { get; set; }

        public double Pressure { get; set; }
    }
}
