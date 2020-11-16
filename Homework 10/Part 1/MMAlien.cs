using System;
using System.Collections.Generic;
using System.Text;

namespace Part_1
{
    class MMAlien : Alien
    {
        private const int DAMAGE = 1;

        public MMAlien(int h, string n)
        {
            SetHealth(h);
            SetName(n);
        }
       
        public static int GetDamage()
        {
            return DAMAGE;
        }
    }
}
