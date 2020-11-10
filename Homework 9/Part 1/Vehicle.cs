using System;
using System.Collections.Generic;
using System.Text;

namespace Part_1
{
    class Vehicle
    {
        public enum Manufacturer
        {
            Acura, 
            BMW,
            Hyundai, 
            Infinity, 
            Jeep, 
            Tesla, 
        }

        public Manufacturer Type { get; set; }

        public int Cylindars { get; set; }

        //Constructors
        public Vehicle()
        {

        }

        public Vehicle(Manufacturer m, int c)
        {
           Type  = m;
           Cylindars = c;
        }

        public void ToString()
        {
            Console.WriteLine("Model: " + (Manufacturer)Type);
            Console.WriteLine("Cylindars: " + Cylindars);
        }

        public bool Equals(Vehicle obj)
        {
            return (this.Type == obj.Type) && (this.Cylindars == obj.Cylindars);
        }
    }
}
