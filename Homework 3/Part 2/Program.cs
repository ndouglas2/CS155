/// Chapter No. 3		Exercise No. 2
/// File Name: Homework3Part2.cs
/// @author: Nate Douglas
/// Date:  September 20, 2020
///
/// Problem Statement: Create a vending machine program that takes in a dollar and outputs the change given in coins.
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt user if the lamp is plugged in
/// 3) If yes, prompt user if the bulb is burned out
/// 4) If no, tell user the lamp may need to be repaired.  
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    class Program
    {
        public static int MONEY_GIVEN = 100;
        static void Main(string[] args)
        {
            string input = "";
            int itemCost = 0;
            int change = 0;
            int quarters = 0;
            int dimes = 0;
            int nickles = 0;
            int remainder = 0;
            
            Console.WriteLine("Welcome to Vendotron 5000! Please note I only accept a single dollar at a time.");
            Console.WriteLine();
            Console.WriteLine("Please input the cost of your item in number of cents in increments of 5 without the decimal. So .25 = 25 and $1 = 100: ");
            input = Console.ReadLine();
            itemCost = Convert.ToInt32(input);
            change = MONEY_GIVEN - itemCost;

            if (itemCost >= 25 && itemCost <= 100)
            {
                quarters = change / 25;
                remainder = change % 25;
                dimes = remainder / 10;
                remainder = remainder % 10;
                nickles = remainder / 5;

                Console.WriteLine("Your item cost " + itemCost + " cents and as you gave me a dollar, your change is: ");
                Console.WriteLine();
                Console.WriteLine(quarters + " Quarters.");
                Console.WriteLine();
                Console.WriteLine(dimes + " Dimes.");
                Console.WriteLine();
                Console.WriteLine(nickles + " Nickles.");
            }
            else
            {
                Console.WriteLine("I am sorry, that is not a valid cost. Please try again. Goodbye.");
                Console.ReadLine();
            }
        }
    }
}
