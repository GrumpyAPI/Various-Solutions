﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

        public int CargoWeight { get; set; }

        public string CargoType { get; set; }
    }
}
