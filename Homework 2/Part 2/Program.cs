/// Chapter No. 2		Exercise No. 1
/// File Name: Homework2Part2.cs
/// @author: Nate Douglas
/// Date:  September 14, 2020
///
/// Problem Statement: Create a program that takes in a temperature in Fahrenheit and outputs it in Celsius.  
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for a temperature in Fahrenheit
/// 3) Take that input and calculate the same temp in Celsius
/// 4) Output to the screen.
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    class DegreeeCalc
    {
        static void Main(string[] args)
        {
            int degreesF = 0;
            double degreesC = 0;
            
            Console.WriteLine("Hello! Please input the degrees in Fahrenheit: ");
            degreesF = Int32.Parse(Console.ReadLine());

            degreesC = 5*(degreesF - 32) / (double)9;
            degreesC = Math.Round(degreesC, 1);

            Console.WriteLine(degreesF + " degrees in Fahrenheit is " + degreesC + " degrees in Celsius.");
            Console.ReadLine();

        }
    }
}
