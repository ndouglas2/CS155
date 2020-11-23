using System;
using System.IO;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Optional Parameters
            Student("Nate", "Douglas", 23, "Computer Science");
            Student("John", "C. Reily");
            Student("Stuart", "Little", 24);
            Console.WriteLine();

            //Named Parameters
            Console.WriteLine(AddNumber(12, 13));
            Console.WriteLine(AddNumber(secondNum: 13, firstNum: 12));
            Console.WriteLine();

            //Variable # of Parameters
            Console.WriteLine(MultiplyNumber(5, 6));
            Console.WriteLine(MultiplyNumber(5, 6, 7));
            Console.WriteLine(MultiplyNumber(5, 6, 7, 8));
        }

        //Method for Optional Parameters
        public static void Student(string fname, string lname, int age = 20, string major = "Political Science")
        {
            Console.WriteLine("First Name: {0} Last Name: {1} Age: {2} Major: {3}", fname, lname, age, major);
        }

        //Method for Named Parameters
        public static int AddNumber(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        //Method for Variable # of Parameters
        public static int MultiplyNumber(params int[] num)
        {
            int result = 1;

            foreach(int i in num)
            {
                result *= i;
            }

            return result;
        }
    }
}
