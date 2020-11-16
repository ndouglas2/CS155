using System;
using System.Collections.Generic;
using System.Text;

namespace Part_1
{
    class SnakeAlien : Alien
    {
        private const int DAMAGE = 6;

        public SnakeAlien(int h, string n)
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
