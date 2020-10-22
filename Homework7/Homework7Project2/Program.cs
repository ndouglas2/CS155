/// Chapter No. 7		Exercise No. 2
/// File Name: Homework7Part2.cs
/// @author: Nate Douglas
/// Date:  October 21, 2020
///
/// Problem Statement: Create a Temperature Class and a driver program to test its methods.
/// 
/// 
/// Overall Plan:
/// 1) Create a temperature Class with constructors, getters and setters, and methods for equals, a toString method, and converting the temps to F and C.
/// 2) Create a driver program that tests these methods.  
/// 

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For the Object setTempOnly: ");
            Temperature setTempOnly = new Temperature(65);
            Console.WriteLine(setTempOnly.getFahrenheit());
            setTempOnly.setScale('F');
            Console.WriteLine(setTempOnly.String());

            Console.WriteLine("For the Object setScaleOnly: ");
            Temperature setScaleOnly = new Temperature('F');
            Console.WriteLine(setScaleOnly.GetCelsius());
            setScaleOnly.setTemp(70);
            Console.WriteLine(setScaleOnly.String());
            if (setTempOnly.Equals(setScaleOnly))
            {
                Console.WriteLine("setTempOnly and setScaleOnly are equal");
            }
            else
            {
                Console.WriteLine("setTempOnly and setScaleOnly are NOT equal");
            }

            Console.WriteLine("For the Object setBoth: ");
            Temperature setBoth = new Temperature(32, 'F');
            Console.WriteLine(setBoth.String());

            Console.WriteLine("For the Object setNone: ");
            Temperature setNone = new Temperature();
            setNone.setBoth(32, 'F');

            if (setBoth.Equals(setNone))
            {
                Console.WriteLine("setBoth and setNone are equal");
            }
            else
            {
                Console.WriteLine("setBoth and setNone are NOT equal");
            }


        }
    }
}
