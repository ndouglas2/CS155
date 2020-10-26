using System;

namespace Lecture8Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pizza 1
            Pizza pizza1 = new Pizza();
            pizza1.setSize("small");
            pizza1.setNumCheese(1);
            pizza1.setNumPep(2);
            pizza1.setNumHam(0);
            pizza1.ToString();
            //Pizza 2
            Pizza pizza2 = new Pizza("large", 1, 1, 2);
            pizza2.ToString();
        }
    }
}
