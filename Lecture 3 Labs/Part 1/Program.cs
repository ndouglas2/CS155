/// Chapter No. 3		Exercise No. 1
/// File Name: Lab3Part1.cs
/// @author: Nate Douglas
/// Date:  September 14, 2020
///
/// Problem Statement: Create a program that takes in a first and last name, and outputs that name in Pig Latin. 
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for their first and last name
/// 3) Store those names in two variables
/// 4) Extract the first letter of each name. 
/// 5) Move that letter to the end of the variable.  
/// 6) Add "Ay" to the end of each new name
/// 7) Print to the screen. 
/// 

using System;
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
            String firstName = " ";
            String lastName = " ";

            Console.WriteLine("Please Enter your first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("Please Enter your last name:");
            lastName = Console.ReadLine();

            printPigLatin(firstName, lastName);
        }

        static void printPigLatin(String firstName, String lastName)
        {
            String pigLatinFirstName = firstName.Substring(1, firstName.Length - 1) + firstName.Substring(0, 1).ToLower() + "ay";
            pigLatinFirstName = pigLatinFirstName.Substring(0, 1).ToUpper() + pigLatinFirstName.Substring(1, pigLatinFirstName.Length - 1);

            String pigLatinLastName = lastName.Substring(1, lastName.Length - 1) + lastName.Substring(0, 1).ToLower() + "ay";
            pigLatinLastName = pigLatinLastName.Substring(0, 1).ToUpper() + pigLatinLastName.Substring(1, pigLatinLastName.Length - 1);

            Console.WriteLine("Your name in Pig Latin is: " + pigLatinFirstName + pigLatinLastName);
        }
    }
}
