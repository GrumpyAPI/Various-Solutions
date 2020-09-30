using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Catalogue
{
    class Catalogue
    {
        public Catalogue()
        {
            Car = new Car();
            Truck = new Truck();
        }

        public Car Car { get; set; }

        public Truck Truck { get; set; }
    }
}
