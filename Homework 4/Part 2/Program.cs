/// Chapter No. 4		Exercise No. 2
/// File Name: Homework4Part2.cs
/// @author: Nate Douglas
/// Date:  September 28, 2020
///
/// Problem Statement: Write a program that prints the statistics for 8 coin tosses.
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt for 8 inputs of coin tosses seperately 
/// 3) Increment the total number of coin tosses each time, plus the individual number of heads or tails
/// 4) Calculate the percentage of heads and tails
/// 5) Output results to screen 
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
        static void Main(string[] args)
        {
            string coinResult = " ";
            int numHeads = 0;
            int numTails = 0;
            int total = 0;

            double percentHeads = 0;
            double percentTails = 0;

            Console.WriteLine("Please flip a coin 8 times and enter each heads as h and each tails as t.");
            Console.WriteLine("Press enter after each entry.");

            for (int i = 1; i <= 8; i++)
            {
                coinResult = Console.ReadLine();
                coinResult = coinResult.ToLower();

                if (coinResult == "h")
                {
                    numHeads++;
                }
                else if (coinResult == "t")
                {
                    numTails++;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid input, please try again");
                    i--;
                }

                total = i;

                Console.WriteLine("Toss " + i + ": " + coinResult);
                Console.WriteLine();
            }

            percentHeads = (numHeads / (double)total) * 100;
            percentTails = (numTails / (double)total) * 100;

            Console.WriteLine("Number of heads: " + numHeads);
            Console.WriteLine();
            Console.WriteLine("Number of tails: " + numTails);
            Console.WriteLine();
            Console.WriteLine("Percent heads: " + percentHeads);
            Console.WriteLine();
            Console.WriteLine("Percent tails: " + percentTails);
            Console.ReadLine();
        }
    }
}
