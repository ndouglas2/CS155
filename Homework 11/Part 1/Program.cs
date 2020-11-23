/// Chapter No. 11		Exercise No. 1
/// File Name: Homework11Part1.cs
/// @author: Nate Douglas
/// Date:  November 23, 2020
///
/// Problem Statement: Create a student class and main method that allows reading names and scores from a file, computing average and median, and then writing to a new file
/// 
/// 
/// Overall Plan:
/// 1) Create a Student class that extends IComparable with the necessary instance variables, constructors, etc.
/// 2) Create a CompareTo method that allows for list sorting within the Student Class
/// 3) Create mehtods for calculating average and median
/// 4) Open the file studentInfo.txt, and take the information and store it as objects in a list called sudents
/// 5) Open the file to write to StudentStats.txt, and write the average and median of the student scores. 
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int total = 0;
            List<Student> students = new List<Student>();

            try
            {
                StreamReader sr = new StreamReader("studentInfo.txt");

                while((line = sr.ReadLine()) != null)
                {
                    string[] lineData = line.Split(' ');
                    var fname = lineData[0];
                    var lname = lineData[1];
                    var score = Int32.Parse(lineData[2]); 
                    var student = new Student(fname, lname, score);
                    students.Add(student);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            students.Sort();

            foreach(var s in students)
            {
                total += s.Score;
            }

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("StudentStats.txt"))
            {
                try
                {
                    sw.WriteLine("The average of all scores is: " + Student.CalcAvg(total, students));
                    sw.WriteLine("The median of all scores is: " + Student.CalcMedian(students));
                    Console.WriteLine("Successfully Wrote to StudentStats.txt");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }

            
        }
    }
}
