using System;
using System.Collections.Generic;
using System.Text;

namespace Part_1
{
    class OgreAlien : Alien
    {
        
        private const int DAMAGE = 10;

        public OgreAlien(int h, string n)
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
