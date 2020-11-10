/// Chapter No. 9		Exercise No. 1
/// File Name: Homework9Part1.cs
/// @author: Nate Douglas
/// Date:  November 9, 2020
///
/// Problem Statement: Create three classes, one for a vehicle, one for a truck that extends vehicle and one for a person. Plus a driver program to test all methods
/// 
/// 
/// Overall Plan:
/// 1) Create a Vehicle class that contains variables for Manufacturer type and cylindar type. 
/// 2) Add a class called Truck that extends Vehicle that includes variables for tow capacity and load capacity.
/// 3) Add a Person class that includes a variable for the name. 
/// 4) Include toString and Equals methods for all classes. 
/// 5) Create a driver program that tests all methods via 2 objects per class.
/// 

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle hyundai = new Vehicle(Vehicle.Manufacturer.Hyundai, 4);
            Vehicle acura = new Vehicle(Vehicle.Manufacturer.Acura, 6);
            Console.WriteLine("First Vehicle: ");
            hyundai.ToString();

            Console.WriteLine();
            Console.WriteLine("Second Vehicle: ");
            acura.ToString();

            Console.WriteLine();
            Console.WriteLine("Are they equal? ");
            Console.WriteLine(acura.Equals(hyundai));


            Truck tesla = new Truck();
            tesla.LoadCap = 1000;
            tesla.TowCap = 3000;
            tesla.Type = (Vehicle.Manufacturer)5;
            tesla.Cylindars = 8;

            Truck jeep = new Truck(4000, 6000);
            jeep.Type = (Vehicle.Manufacturer)4;
            jeep.Cylindars = 8;

            Console.WriteLine();
            Console.WriteLine("First Truck:");
            tesla.ToString();

            Console.WriteLine();
            Console.WriteLine("Second truck: ");
            jeep.ToString();

            Console.WriteLine();
            Console.WriteLine("Are they equal? ");
            Console.WriteLine(tesla.Equals(jeep));

            Person james = new Person("James");
            Person john = new Person();
            john.Name = "John";

            Console.WriteLine();
            Console.WriteLine("First person: ");
            james.ToString();

            Console.WriteLine();
            Console.WriteLine("Second person: ");
            john.ToString();

            Console.WriteLine();
            Console.WriteLine("Are they equal?");
            Console.WriteLine(james.Equals(john));

        }
    }
}
