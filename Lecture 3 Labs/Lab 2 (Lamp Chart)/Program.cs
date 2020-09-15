/// Chapter No. 3		Exercise No. 2
/// File Name: Lab3Part2.cs
/// @author: Nate Douglas
/// Date:  September 14, 2020
///
/// Problem Statement: Model the lamp chart as featured in the slides.
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

namespace Lab_2__Lamp_Chart_
{
    class Program
    {
        static void Main(string[] args)
        {
            String response = " ";

            Console.WriteLine("Oh no! Your lamp seems to not be working! Is it plugged in?");
            response = Console.ReadLine();
            response = response.ToLower();

            if (response == "yes")
            {
                Console.WriteLine("Hmm... have you tried replacing the bulb? It may be burned out");
                response = Console.ReadLine();
                response = response.ToLower();

                if (response == "yes")
                {
                    Console.WriteLine("Well I am stumped, you may need to repair the lamp.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Then I suggest you replace the bulb and see if that helps.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Then plug it in!");
                Console.ReadLine();
            }

        }
    }
}
