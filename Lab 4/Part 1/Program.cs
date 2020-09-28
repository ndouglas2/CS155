using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Part_1
{
    class Program
    {

        public static int SPEED_LIMIT = 65;
        static void Main(string[] args)
        {
            /*int currentSpeed = 0;
            int ticketCost = 0;

            Console.WriteLine("Please enter the speed you were going: ");
            currentSpeed = Convert.ToInt32(Console.ReadLine());

            if (currentSpeed <= SPEED_LIMIT)
            {
                Console.WriteLine("Congrats! You were going the speed limit.");
            }
            else if (currentSpeed >= (SPEED_LIMIT + 25))
            {
                ticketCost = 60 + (7 * (currentSpeed - SPEED_LIMIT)) + 250;
                Console.WriteLine("Wow you were going fast! Sorry, but that is a $" + ticketCost + " ticket.");
            }
            else
            {
                ticketCost = 60 + (7 * (currentSpeed - SPEED_LIMIT));
                Console.WriteLine("Well I guess you were going fast but it could have been worse. You will be issued a ticket of $" + ticketCost);
            }
            */
            //Loop example: will help with homework
            int numberA = 0, numberB= 0, numberC = 0, numberD = 0, numberF = 0, total = 0, grade = 0;
            double percentA = 0.0, percentB = 0.0, percentC = 0.0, percentD = 0.0, percentF = 0.0;

            
            while (grade >= 0)
            {
                Console.WriteLine("Please enter a grade, When finished, please enter -1: ");
                grade = Convert.ToInt32(Console.ReadLine());

                if (grade >= 90 && grade <= 100)
                {
                    numberA++;
                    total++;
                }
                else if (grade >= 80 && grade <= 89)
                {
                    numberB++;
                    total++;
                }
                else if (grade >= 70 && grade <= 79)
                {
                    numberC++;
                    total++;
                }
                else if (grade >= 60 && grade <= 69)
                {
                    numberD++;
                    total++;
                }
                else if (grade >= 0 && grade <= 59)
                {
                    numberF++;
                    total++;
                }

                
                Console.WriteLine();
            }

            percentA = (numberA / (double)total) *100;
            percentB = (numberB / (double)total) *100;
            percentC = (numberC / (double)total) *100;
            percentD = (numberD / (double)total) *100;
            percentF = (numberF / (double)total) *100;

            Console.WriteLine("Total Grades: " + total);
            Console.WriteLine();
            Console.WriteLine("Number of A's = " + numberA + " Which is " + percentA.ToString("0.00") + "% of the total grades.");
            Console.WriteLine();
            Console.WriteLine("Number of B's = " + numberB + " Which is " + percentB.ToString("0.00") + "% of the total grades.");
            Console.WriteLine();
            Console.WriteLine("Number of C's = " + numberC + " Which is " + percentC.ToString("0.00") + "% of the total grades.");
            Console.WriteLine();
            Console.WriteLine("Number of D's = " + numberD + " Which is " + percentD.ToString("0.00") + "% of the total grades.");
            Console.WriteLine();
            Console.WriteLine("Number of F's = " + numberF + " Which is " + percentF.ToString("0.00") + "% of the total grades.");
            Console.WriteLine();

        }
    }
}
