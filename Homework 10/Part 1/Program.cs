/// Chapter No. 10		Exercise No. 1
/// File Name: Homework10Part1.cs
/// @author: Nate Douglas
/// Date:  November 16, 2020
///
/// Problem Statement: Edit the provided code to be more object oriented
/// 
/// 
/// Overall Plan:
/// 1) Split the code into multiple files.
/// 2) Create separate classes for each Alien type so that they use inheritance rather than the type variable.
/// 3) Create a GetDamage method for each class to return the damage that each type does.
/// 4) Rewrite the CalculateDamage method to use these new methods.
/// 5) Create a driver program to test the new system.
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
            OgreAlien o1 = new OgreAlien(100, "Ogre 1");
            OgreAlien o2 = new OgreAlien(100, "Ogre 2");

            SnakeAlien s1 = new SnakeAlien(100, "Snake 1");
            SnakeAlien s2 = new SnakeAlien(100, "Snake 2");

            MMAlien mm1 = new MMAlien(100, "MM 1");
            MMAlien mm2 = new MMAlien(100, "MM 2");

            AlienPack group = new AlienPack(6);

            group.AddAlien(o1, 0);
            group.AddAlien(o2, 1);
            group.AddAlien(s1, 2);
            group.AddAlien(s2, 3);
            group.AddAlien(mm1, 4);
            group.AddAlien(mm2, 5);

            Console.WriteLine("Alien group damage: " + group.CalculateDamage());

        }
    }
}
