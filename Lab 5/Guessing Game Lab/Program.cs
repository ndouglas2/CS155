using System;

namespace Guessing_Game_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;
            int total = 0;
            int answer = 0;

            Random generator = new Random();
            answer = generator.Next(1, 100);
            
            Console.WriteLine("I have chosen a number between 1 and 100. How many guesses will it take you to get it?");
            do
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < answer)
                {
                    Console.WriteLine("Ooh too low! Try Again.");
                    total++;
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Too high! Try Again.");
                    total++;
                }

            } while (guess != answer);

            //to account for the final guess that ends the loop
            total++;
            Console.WriteLine("Congrats! You got it right! I was thinking of " + answer + ".");
            Console.WriteLine();
            Console.WriteLine("It took you " + total + " guesses to get it right.");
            Console.ReadLine();
        }
    }
}
