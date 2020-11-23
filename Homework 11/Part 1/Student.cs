using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Part_1
{
    class Student : IComparable<Student>
    {
        //Instance Variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }

        //Constructors
        public Student()
        {

        }
        public Student(string f, string l, int s)
        {
            FirstName = f;
            LastName = l;
            Score = s;
        }

        //Methods
        public static int CalcAvg(int t, List<Student> s)
        {
            int total = t;
            int avg = total / s.Count;

            return avg;
        }

        public static int CalcMedian(List<Student> s)
        {
            double position = 0;
            double median = 0.0;
            
            if(s.Count % 2 == 0)
            {
                median = ((s[(s.Count / 2) - 1].Score + s[(s.Count / 2)].Score) / 2);
                return Convert.ToInt32(median);
            }
            else if (s.Count % 2 == 1)
            {
                position = Math.Ceiling((double)s.Count / 2) - 1;
            }

            return s[Convert.ToInt32(position)].Score;
        }
        public int CompareTo(Student obj)
        {
            if(this.Score == obj.Score)
            {
                return this.FirstName.CompareTo(obj.FirstName);
            }

            return obj.Score.CompareTo(this.Score);
        }
    }
}
