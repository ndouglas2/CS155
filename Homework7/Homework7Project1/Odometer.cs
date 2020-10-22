using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7Project1
{
    class Odometer
    {
        //Instance Variables
        private int miles;
        private double fuelUsed; 

        //Constructors
        public Odometer()
        {
            miles = 0;
            fuelUsed = 15;
        }
        public Odometer(int miles, double fuelUsed)
        {
            this.miles = miles;
            this.fuelUsed = fuelUsed;
        }

        //Getters and Setters
        public void SetMiles(int m)
        {
            miles = m;
        }
        public int GetMiles()
        {
            return miles;
        }

        public void SetFuelUsed(double f)
        {
            fuelUsed = f;
        }
        public double GetFuelUsed()
        {
            return fuelUsed;
        }

        //Methods
        public void Reset()
        {
            miles = 0;
            fuelUsed = 0;
        }

        public void Add(int m, double f)
        {
            miles += m;
            fuelUsed += f;
        }

        public double MPG()
        {
           return (miles / fuelUsed);
        }

        public string String()
        {
            return " " + miles + " Miles Driven" + fuelUsed + " Fuel Used";
        }

        public bool Equals(Odometer other)
        {
            return (this.miles == other.miles) && (this.fuelUsed == other.fuelUsed);
        }
    }
}
