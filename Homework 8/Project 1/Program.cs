/// Chapter No. 8		Exercise No. 1
/// File Name: Homework8Part1.cs
/// @author: Nate Douglas
/// Date:  October 26, 2020
///
/// Problem Statement: Create a program that simulates 10,000 duels between three people.
/// 
/// 
/// Overall Plan:
/// 1) Create a Duelist class that contains Name, shooting accuracy, and a value for if they are alive or not. 
/// 2) Add a method to this class that picks a random number and determines if they hit their target. If they do, the target is killed. 
/// 3) Create a loop that emulates 10,000 battles. Inside the loop is logic for each person to pick their target. 
/// 4) Output the number of wins to the console. 
/// 

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duelist aaron = new Duelist("Aaron", .33, true);
            Duelist bob = new Duelist("Bob", .50, true);
            Duelist charlie = new Duelist("Charlie", .995, true);
            int aaronWins = 0;
            int bobWins = 0;
            int charlieWins = 0;
            int total = 0;


            for(int i = 0; i <= 10000; i++)
            {
                aaron.Alive = true;
                bob.Alive = true;
                charlie.Alive = true;
                
                do
                {
                    if (aaron.Alive && charlie.Alive)
                    {
                        aaron.ShootAtTarget(charlie);
                    }
                    else if (aaron.Alive && charlie.Alive == false && bob.Alive)
                    {
                        aaron.ShootAtTarget(bob);
                    }
                    else if (aaron.Alive && charlie.Alive == false && bob.Alive == false)
                    {
                        //Console.WriteLine("Aaron Wins!");
                        aaronWins++;
                        break;
                    }

                    if (bob.Alive && charlie.Alive)
                    {
                        bob.ShootAtTarget(charlie);
                    }
                    else if (bob.Alive && charlie.Alive == false && aaron.Alive)
                    {
                        bob.ShootAtTarget(aaron);
                    }
                    else if (bob.Alive && charlie.Alive == false && aaron.Alive == false)
                    {
                        //Console.WriteLine("Bob Wins!");
                        bobWins++;
                        break;
                    }

                    if (charlie.Alive && bob.Alive)
                    {
                        charlie.ShootAtTarget(bob);
                    }
                    else if (charlie.Alive && bob.Alive == false && aaron.Alive)
                    {
                        charlie.ShootAtTarget(aaron);
                    }
                    else if (charlie.Alive && bob.Alive == false && aaron.Alive == false)
                    {
                        //Console.WriteLine("Charlie Wins!");
                        charlieWins++;
                        break;
                    }
                } while (aaron.Alive || bob.Alive || charlie.Alive);
                total = i;
            }

            Console.WriteLine("That was " + total + " duels");
            Console.WriteLine("Aaron won " + aaronWins + " duels");
            Console.WriteLine("Bob won " + bobWins + " duels");
            Console.WriteLine("Charlie won " + charlieWins + " duels");
            
            

                  

          






        }
    }
}
