using System;

namespace Lecture6Lab2
{
    public class Fraction
    {
        private int numerator = 0;
        private int denominator = 0;
        private double result = 0.0;

        //constructor
        public Fraction(int numerator, int denominator, double result)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.result = result;
        }

        public Fraction()
        {

        }

        //Setters and Getters for numerator and denominator
        public void SetNumerator(int numerator)
        {
            this.numerator = numerator;
        }

        public int GetNumerator()
        {
            return numerator;
        }

        public void SetDenominator(int denominator)
        {
            this.denominator = denominator;
        }

        public int GetDenominator()
        {
            return denominator;
        }

        //Other Methods
        public void Division(int numerator, int denominator)
        {
            result = numerator / (double)denominator;
            Console.WriteLine("The fraction " + numerator + "/" + denominator + " equals " + result);
        }

        public int GCD(int a, int b)
        {
            while(a != b)
            {
                if(a < b)
                {
                    b = b - a;
                }
                else
                {
                    a = a - b;
                }
            }
            return a;
        }
        public int LowestTerms(int a, int b)
        {
            int remainder = a;
            int quotient = 0;

            while (remainder >= b)
            {
                remainder = remainder - b;
                quotient++;
            }
            return (quotient);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the numerator of a fraction:");
            Fraction original = new Fraction();
            original.SetNumerator(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Now Please enter the denominator: ");
            original.SetDenominator(Convert.ToInt32(Console.ReadLine()));

            original.Division(original.GetNumerator(), original.GetDenominator());

            int reducedNumerator = 0;
            int reducedDenominator = 0;

            int divisor = original.GCD(original.GetNumerator(), original.GetDenominator());

            if (divisor != 1)
            {
                reducedNumerator = original.LowestTerms(original.GetNumerator(), divisor);
                reducedDenominator = original.LowestTerms(original.GetDenominator(), divisor);
                Console.WriteLine("Your fraction can be reduced to " + reducedNumerator + "/" + reducedDenominator);
            }
            else
            {
                Console.WriteLine("Your fraction cannot be reduced.");
            }

         
        }

    }   
}
