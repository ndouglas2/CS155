using System;
using System.IO;
using System.Collections.Generic;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;
            Driver user = new Driver();

            user.FillInventory(user);

            do
            {

                Menu.DisplayMenu();
                choice = Int32.Parse(Console.ReadLine());
                Menu.Choice(user, choice);

            } while (choice != 6);

            Environment.Exit(1);
            
        }
    }
}
