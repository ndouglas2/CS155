/// Chapter No. 6		Exercise No. 1
/// File Name: Homework6Part1.cs
/// @author: Nate Douglas
/// Date:  October 12, 2020
///
/// Problem Statement: Write a program that counts using a Counter class and a count object.
/// 
/// 
/// Overall Plan:
/// 1) Create a Counter Class with the following methods: A method to get the count, print the count, increase it by 1, decrease it by 1, and set it to 0
/// 2) Create a loop that will display a menu with options for the user
/// 3) Each option corresponds with the above methods
/// 4) In the decrement method, do not let the count go below 0.  
/// 

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Part1_Counter
{
    class Counter
    {
        private int number = 0;

        public int GetCount()
        {
            return number;
        }

        public void SetCountToZero()
        {
            number = 0;
        }

        public void IncreaseCount()
        {
            number++;
        }

        public void DecreaseCount()
        {
            if (number == 0)
            {
                Console.WriteLine("Count is at 0, cannot decrease further");
            }
            else
            {
                number--;
            }
        }

        public void PrintCount()
        {
            Console.WriteLine("The count is currently: " + number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter count = new Counter();
            int choice = 0;

            do
            {
                count.PrintCount();
                Console.WriteLine("Please Select an option: ");
                Console.WriteLine("1)Set Count to 0");
                Console.WriteLine("2)Increase count by 1");
                Console.WriteLine("3)Decrease count by 1");
                Console.WriteLine("To exit, please enter -1.");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        count.SetCountToZero();
                        break;
                    case 2:
                        count.IncreaseCount();
                        break;
                    case 3:
                        count.DecreaseCount();
                        break;
                    default:
                        Console.WriteLine("That is not a valid option, please try again.");
                        break;
                }
                Console.Clear();

            } while (choice != -1);
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
