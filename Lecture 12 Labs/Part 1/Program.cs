using System;
using System.IO;
using System.Collections.Generic;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int choice = 0;
            string name = " ";
            Dictionary<string, string> boyNames = new Dictionary<string, string>();
            Dictionary<string, string> girlNames = new Dictionary<string, string>();
            try
            {

                StreamReader sr = new StreamReader("boynames-1.txt");

                while((line = sr.ReadLine()) != null)
                {
                    string[] lineData = line.Split(' ');
                    boyNames.Add(lineData[0].ToUpper(), lineData[1]);
                }

                StreamReader sr2 = new StreamReader("girlnames-1.txt");

                while ((line = sr2.ReadLine()) != null)
                {
                    string[] lineData = line.Split(' ');
                    girlNames.Add(lineData[0].ToUpper(), lineData[1]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Baby Names Ranking System");
                Console.WriteLine("Please make your selection from the list below: ");
                Console.WriteLine("1. Search Boy Names");
                Console.WriteLine("2. Search Girl Names");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.Write("Your selection: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("BOY NAMES");
                        Console.WriteLine("Please enter the name you wish to search for: ");
                        name = Console.ReadLine().ToUpper();

                        if (boyNames.ContainsKey(name))
                        {
                            string births = boyNames[name];
                            Console.WriteLine("Name: {0} Number of Births: {1}", name, births);
                        }
                        else
                        {
                            Console.WriteLine("Name could not be found in Registry.");
                        }

                        Console.WriteLine("Press enter to return to the main menu.");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("GIRL NAMES");
                        Console.WriteLine("Please enter the name you wish to search for: ");
                        name = Console.ReadLine().ToUpper();

                        if (girlNames.ContainsKey(name))
                        {
                            string births = girlNames[name];
                            Console.WriteLine("Name: {0} Number of Births: {1}", name, births);
                        }
                        else
                        {
                            Console.WriteLine("Name could not be found in Registry.");
                        }

                        Console.WriteLine("Press enter to return to the main menu.");
                        Console.ReadLine();
                        break;

                    case 3:
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("That is not a valid option.");
                        break;

                }

            } while (choice != 3) ;

            Environment.Exit(1);
        }
    }
}
