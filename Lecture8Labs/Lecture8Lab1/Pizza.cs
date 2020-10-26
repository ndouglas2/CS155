using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture8Lab1
{
    class Pizza
    {
        //Instance Variables
        private string size;
        private int numCheese;
        private int numPep;
        private int numHam;
        //Constructors
        public Pizza()
        {
            size = "medium";
            numCheese = 1;
            numPep = 0;
            numHam = 0;
        }
        public Pizza(string size, int numCheese, int numPep, int numHam)
        {
            this.size = size;
            this.numCheese = numCheese;
            this.numPep = numPep;
            this.numHam = numHam;
        }

        //Getters and Setters
        public void setSize(string s)
        {
            size = s;
        }
        public string getSize()
        {
            return size;
        }
        public void setNumCheese(int c)
        {
            numCheese = c;
        }
        public int getNumCheese()
        {
            return numCheese;
        }
        public void setNumPep(int p)
        {
            numPep = p;
        }
        public int getNumPep()
        {
            return numPep;
        }
        public void setNumHam(int h)
        {
            numHam = h;
        }
        public int getNumHam()
        {
            return numHam;
        }

        //Methods
        public double CalculateCost()
        {
            int toppingsTotal = numCheese + numPep + numHam;
            double total = 0.0;
            if (size == "small")
            {
                total = 10 + (toppingsTotal * 2);
            }
            else if (size == "medium")
            {
                total = 12 + (toppingsTotal * 2);
            }
            else if (size == "large")
            {
                total = 14 + (toppingsTotal * 2);
            }
            return total;
        }
        public void ToString()
        {
            Console.WriteLine("Your order is as follows:");
            Console.WriteLine("Size: " + getSize());
            Console.WriteLine("Number of cheese toppings: " + getNumCheese());
            Console.WriteLine("Number of pepperoni toppings: " + getNumPep());
            Console.WriteLine("Number of ham toppings: " + getNumHam());
            Console.WriteLine("Total: $" + CalculateCost());
        }
    }
}
