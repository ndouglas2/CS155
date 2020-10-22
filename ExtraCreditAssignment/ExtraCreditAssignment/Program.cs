using System;
using System.Runtime.ExceptionServices;

namespace ExtraCreditAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentance = "";
            Console.WriteLine("Please enter a sentance of your choosing and press enter: ");
            sentance = Console.ReadLine();
            char[] sentanceArray = new char[sentance.Length];

            for (int i = 0; i < sentance.Length; i++)
            {
                sentanceArray[i] = sentance[i];
            }


            for (int i= 0 ; i < sentanceArray.Length; i++)
            {
                if(i %2 == 0)
                {
                    sentanceArray[i] = char.ToUpper(sentanceArray[i]);
                    
                }
                else
                {
                    continue;
                }
                
            }
            Console.WriteLine("How that looks with every other letter capitalized: ");
            for (int i = 0; i < sentanceArray.Length; i++)
            {
                Console.Write(sentanceArray[i]);
            }
            Console.ReadLine();
        }
    }
}
