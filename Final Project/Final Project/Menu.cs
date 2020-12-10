using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    class Menu : Driver //Class for displaying the home menu and subsequent menu choices
    {
        //Variables for the main menu - Created as Variables for ease of changing if necessary
        private static string header = "Douglas Hardware Inventory Management v1.0";
        private static string choice1 = "1. Display Current Inventory";
        private static string choice2 = "2. Change Quantity of an Item";
        private static string choice3 = "3. Remove an Item";
        private static string choice4 = "4. Add an Item";
        private static string choice6 = "6. Exit";
        private static string choice5 = "5. Generate Report";
        private static string footer = "Your selection: ";

        //Displays main Menu
        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)) + "}", header));
            Console.WriteLine();
            Console.WriteLine(String.Format("{0,40}", choice1));
            Console.WriteLine(String.Format("{0,41}", choice2));
            Console.WriteLine(String.Format("{0,29}", choice3));
            Console.WriteLine(String.Format("{0,26}", choice4));
            Console.WriteLine(String.Format("{0,30}", choice5));
            Console.WriteLine(String.Format("{0,19}", choice6));
            Console.WriteLine();
            Console.Write(String.Format("{0,28}", footer));
        }

        //Logic for which menu to go to based on user's choice
        public static void Choice(Driver obj, int c)
        {
            switch (c)
            {
                case 1: //Prints all current entries in inventory
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)) + "}", "CURRENT INVENTORY"));
                    Console.WriteLine();
                    foreach (var l in obj.inventory)
                    {
                        Console.WriteLine("Item: {0} Quantity: {1}", l.Key, l.Value);
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to return to main menu.");
                    Console.ReadLine();
                    break;

                case 2: //Allows for the changing of an item's quantity
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)) + "}", "CHANGE QUANTITY"));
                    Console.WriteLine();
                    Console.WriteLine("Please enter the item you would like to change");
                    entryItem = Console.ReadLine().ToUpper();

                    if (obj.inventory.ContainsKey(entryItem))
                    {
                        Console.WriteLine("Please enter the new value for " + entryItem);
                        obj.inventory[entryItem] = Int32.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Item could not be found");
                    }
                    Console.WriteLine("Press Enter to return to main menu.");
                    Console.ReadLine();
                    break;

                case 3: //Allows for the Removing of an item entirely
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)) + "}", "REMOVE ITEM FROM DATABASE"));
                    Console.WriteLine();
                    Console.WriteLine("Please enter the item you would like to remove");
                    entryItem = Console.ReadLine().ToUpper();

                    if (obj.inventory.ContainsKey(entryItem))
                    {
                        obj.inventory.Remove(entryItem);
                        Console.WriteLine("Successfully Removed " + entryItem);
                    }
                    else
                    {
                        Console.WriteLine("Item could not be found");
                    }
                    Console.WriteLine("Press Enter to return to main menu.");
                    Console.ReadLine();
                    break;

                case 4: //Allows for Adding a new Item and Quantity
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)) + "}", "ADD ITEM TO DATABASE"));
                    Console.WriteLine();

                    Console.WriteLine("Please enter the item you would like to add");
                    entryItem = Console.ReadLine().ToUpper();

                    Console.WriteLine("Please enter this item's quantity");
                    entryNumber = Int32.Parse(Console.ReadLine());

                    obj.inventory.Add(entryItem, entryNumber);

                    Console.WriteLine("Press Enter to return to main menu.");
                    Console.ReadLine();
                    break;

                case 6: //Exits the Console
                    Environment.Exit(1);
                    break;

                case 5: //Generates a report to InventoryReport.txt
                    DateTime now = DateTime.Now;
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)) + "}", "GENERATE INVENTORY REPORT"));
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to Generate an Inventory report at InventoryReport.txt");
                    Console.ReadLine();


                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter("InventoryReport.txt"))
                    {
                        try
                        {
                            sw.WriteLine("Current Inventory as of: {0}", now);
                            sw.WriteLine();
                            foreach (var l in obj.inventory)
                            {
                                sw.WriteLine("Item: {0} Quantity: {1}", l.Key, l.Value);
                                sw.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine("Succecssfully Generated Report.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception: " + e.Message);
                        }
                    }

                    Console.WriteLine("Press Enter to return to main menu.");
                    Console.ReadLine();
                    break;

                default:

                    Console.WriteLine("That is not a valid option.");
                    break;

            }
        }


    }
}
