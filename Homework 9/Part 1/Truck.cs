using System;
using System.Collections.Generic;
using System.Text;

namespace Part_1
{
    class Truck : Vehicle
    {
        public double LoadCap { get; set; }
        public int TowCap { get; set; }

        public Truck()
        {

        }
        public Truck(double l, int t)
        {
            LoadCap = l;
            TowCap = t;
        }

        public void ToString()
        {
            Console.WriteLine("Model: " + (Manufacturer)Type);
            Console.WriteLine("Cylindars: " + Cylindars);
            Console.WriteLine("Load Capacity in lbs.: " + LoadCap);
            Console.WriteLine("Towing Capacity in lbs.: " + TowCap);
        }

        public bool Equals(Truck obj)
        {
            return (this.LoadCap == obj.LoadCap) && (this.TowCap == obj.TowCap);
        }
    }
}
