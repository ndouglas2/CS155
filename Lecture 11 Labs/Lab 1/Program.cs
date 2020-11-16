using System;
using System.Collections.Generic;


namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            string name = " ";
            
            Dictionary<string, long> phoneBook = new Dictionary<string, long>() { {"JOHN", 4389642575 },
                                                                                {"MARY", 7621694206},
                                                                                {"COLE", 13689845678},
                                                                                {"TYLER", 9853017464},
                                                                                {"FRAN", 8842256135},
                                                                                {"JENNIE", 4876241376} };
            


            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to PhoneBook! There are currently " + phoneBook.Count + " entries in the book.");
                Console.WriteLine("Please make your selection from the list below: ");
                Console.WriteLine("1. Search");
                Console.WriteLine("2. Add Name and Number");
                Console.WriteLine("3. Remove Entry");
                Console.WriteLine("4. Display all");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.Write("Your selection: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("SEARCH");
                        Console.WriteLine();
                        Console.WriteLine("Please enter the name you wish to search for: ");
                        name = Console.ReadLine().ToUpper();

                        if (phoneBook.ContainsKey(name))
                        {
                            long value = phoneBook[name];
                            Console.WriteLine("Found this entry: ");
                            Console.WriteLine("Name: {0} Phone Num: {1}", name, value);
                        }
                        else
                        {
                            Console.WriteLine("Entry could not be found");
                        }

                        Console.WriteLine("Press Enter to return to main menu.");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("ADD ENTRY");
                        Console.WriteLine();
                        string entryName = "";
                        long entryNumber = 0;

                        Console.WriteLine("Please enter the Name you wish to add: ");
                        entryName = Console.ReadLine().ToUpper();

                        Console.WriteLine("Please enter the Number you wish to add: ");
                        entryNumber = Int64.Parse(Console.ReadLine());

                        phoneBook.Add(entryName, entryNumber);

                        Console.WriteLine("Press Enter to return to main menu.");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("REMOVE ENTRY");
                        Console.WriteLine();
                        Console.WriteLine("Please enter the name you wish to remove: ");
                        string removeName = Console.ReadLine().ToUpper();

                        if (phoneBook.ContainsKey(removeName))
                        {
                            phoneBook.Remove(removeName);
                            Console.WriteLine("Successfully removed " + removeName);
                        }
                        else
                        {
                            Console.WriteLine("Entry could not be found");
                        }

                        Console.WriteLine("Press Enter to return to main menu.");
                        Console.ReadLine();
                        break;

                    case 5:
                        Environment.Exit(1);
                        break;

                    case 4:
                        Console.WriteLine("All current entries:");
                        foreach(KeyValuePair<string, long> ele1 in phoneBook)
                        {
                            Console.WriteLine("Name: {0} Phone Num: {1}", ele1.Key, ele1.Value);
                        }
                        Console.WriteLine("Press Enter to return to main menu.");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("That is not a valid option.");
                        break;
                }

            } while (choice != 5);

            Environment.Exit(1);
        }
    }
}
