/// Chapter No. 5		Exercise No. 1
/// File Name: Homework5Part1.cs
/// @author: Nate Douglas
/// Date:  October 5, 2020
///
/// Problem Statement: Write a program that takes in one array, copies it to a second, and then prints both.
/// 
/// 
/// Overall Plan:
/// 1) Initialize two arrays, one with 10 values and one that is empty
/// 2) Create a loop that sets the second empty array equal to the first array for each value
/// 3) Print both arrays to ensure the copying was successful
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
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] copy = new int[array.Length];


            for (int i = 0; i <= array.Length - 1; i++)
            {
                copy[i] = array[i];
            }

            Console.WriteLine("Original Array: ");
            for(int i=0; i<=array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Copy Array: ");
            for (int i = 0; i <= copy.Length - 1; i++)
            {
                Console.WriteLine(copy[i]);
            }

        }
    }
}
