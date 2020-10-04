/// Chapter No. 5		Exercise No. 2
/// File Name: Homework5Part2.cs
/// @author: Nate Douglas
/// Date:  October 5, 2020
///
/// Problem Statement: Write a program that takes reverses an array using methods.
/// 
/// 
/// Overall Plan:
/// 1) Create three methods:
/// 2) One called GenerateNumbers that uses a simple for loop to set each value in the array equal to its index
/// 3) One called PrintArray that uses a for loop to print every value in the array
/// 4) Lastly one called ReverseArray that swaps all the values in the array. 
/// 5) Call Each of these methods using the array in the Main Method. 
/// 

using System;
using System.CodeDom.Compiler;
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
            int[] original = new int[10];
            GenerateNumbers(original);
            ReverseArray(original);
            PrintArray(original);
        }

        //Generates the values in the array by setting them equal to their index for ease of this assignment
        public static void GenerateNumbers(int[] arr)
        {
            for(int i= 0; i< arr.Length; i++)
            {
                arr[i] = i;
            }
        }

        //Prints every value in the array
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //Reverses all of the values in the arraya
        public static void ReverseArray(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < (arr.Length/2); i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
        }
    }
}
