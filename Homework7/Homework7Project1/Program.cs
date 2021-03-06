﻿/// Chapter No. 7		Exercise No. 1
/// File Name: Homework7Part1.cs
/// @author: Nate Douglas
/// Date:  October 21, 2020
///
/// Problem Statement: Create an Odometer Class and a driver program to test its methods.
/// 
/// 
/// Overall Plan:
/// 1) Create a Odometer Class with constructors, getters and setters, and methods for Reseting the values, adding to the values and the MPG
/// 2) Create a driver program that tests these methods.  
/// 

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer trip1 = new Odometer();
            trip1.Add(65, 15);
            Console.WriteLine("Fuel used for Trip 1: " + trip1.GetFuelUsed());
            Console.WriteLine("MPG for Trip 1: " + trip1.MPG());
            Console.WriteLine(trip1.String());

            Odometer trip2 = new Odometer(50, 10);
            trip2.Add(100, 20);
            Console.WriteLine("Fuel used for Trip 2: " + trip2.GetFuelUsed());
            Console.WriteLine("MPG for Trip 2: " + trip2.MPG());
            Console.WriteLine(trip2.String());

            if (trip1.Equals(trip2))
            {
                Console.WriteLine("The two trips are the same.");
            }
            else
            {
                Console.WriteLine("The two trips are not the same.");
            }

            trip1.Reset();
            trip2.Reset();
            Console.WriteLine("Now the values have been reset:");
            Console.WriteLine(trip1.String());
            Console.WriteLine(trip2.String());

        }

    
    }
}
