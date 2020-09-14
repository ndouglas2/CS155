/// Chapter No. 2		Exercise No. 1
/// File Name: Homework2Part1.cs
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
    class PigLatin
    {
        static void Main(string[] args)
        {
            string firstName = " ";
            string lastName = " ";
            string pigFirstName = " ";
            string pigLastName = " ";

            string firstLetterFN = " ";
            string firstLetterLN = " ";

            string firstNameNoFirstLetter = " ";
            string lastNameNoFirstLetter = " ";

            Console.WriteLine("Hello! Please input your first name and hit enter: ");
            firstName = Console.ReadLine();
            firstName = firstName.ToLower();

            Console.WriteLine("What is your last name?: ");
            lastName = Console.ReadLine();
            lastName = lastName.ToLower();

            firstLetterFN = firstName.Substring(0, 1);
            firstLetterLN = lastName.Substring(0, 1);

            firstNameNoFirstLetter = firstName.Substring(1);
            lastNameNoFirstLetter = lastName.Substring(1);

            pigFirstName = firstNameNoFirstLetter + firstLetterFN + "ay";
            pigLastName = lastNameNoFirstLetter + firstLetterLN + "ay";

            Console.WriteLine("Hello " + firstName + " " + lastName + "!");
            Console.WriteLine("Your name in Pig Latin is: " + pigFirstName + " " + pigLastName);
        }
    }
}
