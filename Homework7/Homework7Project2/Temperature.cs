using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7Project2
{
    class Temperature
    {
        //Instance Variables
        private float temp;
        private char scale;

        //Constructors
        public Temperature(float t)
        {
            temp = t;
        }
        public Temperature(char s)
        {
            scale = s;
        }
        public Temperature(float t, char s)
        {
            temp = t;
            scale = s;
        }
        public Temperature()
        {
            temp = 0;
            scale = 'C';
        }

        //Getters and Setters
        public float GetCelsius()
        {
            return (temp - 32) * (5 / 9);
        }
        public float getFahrenheit()
        {
            return (temp * (9 / 5)) + 32;
        }
        public void setTemp(float t)
        {
            temp = t;
        }
        public void setScale(char s)
        {
            scale = s;
        }
        public void setBoth(float t, char s)
        {
            temp = t;
            scale = s;
        }

        //Methods
        public string String()
        {
            return "The current temperature is " + temp + " and the current scale is " + scale;
        }
        public bool Equals(Temperature other)
        {
            return (this.temp == other.temp) && (this.scale == other.scale);
        }

    }
}
