/// Chapter No. 1		Exercise No. 1
/// File Name: MyFirstProgram.cs
/// @author: Nate Douglas
/// Date:  August 24, 2020
///
/// Problem Statement: Ask the user to enter two numbers, calculate the sum of
/// these two numbers, and display the sum to the screen
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for two integers
/// 3) Calculate the sum of the integers
/// 4) Print the sum of the integers to the screen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter and so on:");

            // declare two integer variables
            int n1, n2, n3, sum, mult, div;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these two numbers
            sum = n1 + n2 + n3;

            mult = n1 * n2 * n3;

            div = sum / mult;

            // print a message along with the sum of the two numbers
            Console.WriteLine("The sum of those three numbers is");
            Console.WriteLine(sum);

            Console.WriteLine("When you multiply those same numbers you get");
            Console.WriteLine(mult);

            Console.WriteLine("When you divide the sum by the product you get");
            Console.WriteLine(div);


            //Just to pause the screen.
            Console.ReadLine();


        }
    }
}
