using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Final_Project
{
    class Driver
    {
        private static string line;
        public static string entryItem = " ";
        public static int entryNumber = 0;

        public Dictionary<string, int> inventory = new Dictionary<string, int>();

        public void FillInventory(Driver obj)
        {
            try
            {
                StreamReader sr = new StreamReader("InventoryInput.txt");

                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineData = line.Split(',');
                    obj.inventory.Add(lineData[0].ToUpper(), Int32.Parse(lineData[1]));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

    }
}
