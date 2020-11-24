using System;

namespace Lecture_13_Labs_Part_1
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            mydelegate rectdele = new mydelegate(rect.area);

            //Alternative way:
            //mydelegate rectdele = rect.area;

            rectdele += new mydelegate(rect.perimeter);

            //Alternative way:
            //rectdele += rect.perimiter

            rectdele.Invoke(6.0, 4.5);
            Console.WriteLine();
            rectdele.Invoke(15.3, 11.4);
        }
        public delegate void mydelegate(double height, double width);
        public void area(double height, double width)
        {
            Console.WriteLine("The Area is: " + (width * height));
        }

        public void perimeter(double height, double width)
        {
            Console.WriteLine("The Perimeter is: " + (2*(width * height)));
        }
    }

}
