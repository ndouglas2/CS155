using System;
using System.Collections.Generic;
using System.Text;

namespace Part_1
{
    class AlienPack : Alien
    {
        private Alien[] aliens;

        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }
        public Alien[] GetAliens()
        {
            return aliens;
        }
        public int CalculateDamage()
        {
            int damage = 0;

            foreach (Alien a in aliens)
            {
                if (a is MMAlien)
                {
                    damage += MMAlien.GetDamage();
                }
                else if (a is OgreAlien)
                {
                   damage += OgreAlien.GetDamage();
                }
                else if (a is SnakeAlien)
                {
                    damage += SnakeAlien.GetDamage();
                }
            }

            return damage;
        }

    }
}
