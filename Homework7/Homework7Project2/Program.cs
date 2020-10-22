using System;

namespace Homework7Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For the Object setTempOnly: ");
            Temperature setTempOnly = new Temperature(65);
            Console.WriteLine(setTempOnly.getFahrenheit());
            setTempOnly.setScale('F');
            Console.WriteLine(setTempOnly.String());

            Console.WriteLine("For the Object setScaleOnly: ");
            Temperature setScaleOnly = new Temperature('F');
            Console.WriteLine(setScaleOnly.GetCelsius());
            setScaleOnly.setTemp(70);
            Console.WriteLine(setScaleOnly.String());
            if (setTempOnly.Equals(setScaleOnly))
            {
                Console.WriteLine("setTempOnly and setScaleOnly are equal");
            }
            else
            {
                Console.WriteLine("setTempOnly and setScaleOnly are NOT equal");
            }

            Console.WriteLine("For the Object setBoth: ");
            Temperature setBoth = new Temperature(32, 'F');
            Console.WriteLine(setBoth.String());

            Console.WriteLine("For the Object setNone: ");
            Temperature setNone = new Temperature();
            setNone.setBoth(32, 'F');

            if (setBoth.Equals(setNone))
            {
                Console.WriteLine("setBoth and setNone are equal");
            }
            else
            {
                Console.WriteLine("setBoth and setNone are NOT equal");
            }


        }
    }
}
