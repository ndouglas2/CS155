using System;
using System.Collections.Generic;
using System.Text;

namespace Part_1
{
    class Alien
    {
        private int health = 100; //0 = dead, 100 = full
        private string name = "NA";

        public void SetHealth(int h)
        {
            health = h;
        }
        
        public int GetHealth()
        {
            return health;
        }

        public void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
    }
}
