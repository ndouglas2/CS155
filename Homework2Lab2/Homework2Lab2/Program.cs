/// Chapter No. 2		Exercise No. 2
/// File Name: Homework2Lab2.cs
/// @author: Nate Douglas
/// Date:  August 31, 2020
///
/// Problem Statement: Calculate the number of candy bars and gumballs one can purchase with tickets. 
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for number of tickets won
/// 3) Calculate how many candy bars can be purchased with tickets. 
/// 4) Use the remainder to determine how many gumballs can then be purchased. 
/// 5) Print results to screen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tickets, numCandyBars, numGumballs, remainder;

            //Welcome message and prompt for number of tickets won
            Console.WriteLine("Hello! Please enter the number of tickets you have won");
            tickets = Int32.Parse(Console.ReadLine());

            //Calculate number of candy bars purchaseable
            numCandyBars = tickets / 10;

            //Calculate the remaining number of tickets
            remainder = tickets % 10;

            //Use remainder to calculate number of gumballs purchaseable
            numGumballs = remainder / 3;

            //Print results to screen
            Console.WriteLine("With " + tickets + " tickets, you can purchase " + numCandyBars + " candy bar(s) and " + numGumballs + " gumball(s). Congrats!");

            Console.ReadLine();
            
        }
    }
}
