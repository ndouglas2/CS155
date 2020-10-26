using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace Project_1
{
    class Duelist
    {
        //Duelist will hit if the random number is less than their probability score out of 1000. 
        //So Aaron will hit if it is less than or equal to 333, Bob 500 and Charlie 995.

        //Instance Variables
        private string _name;
        private int _shootingAcc;
        private bool _alive;
        //Constructors
        public Duelist()
        {
            Name = "None";
            ShootingAcc = 0;
            Alive = true;
        }
        public Duelist(string n, double s, bool a)
        {
            Name = n;
            ShootingAcc = s;
            Alive = a;
        }

        //Getters and Setters (Use Properties)
        public string Name { get; set; }
        public double ShootingAcc { get; set; }
        public bool Alive { get; set; }

        //Methods
        public void ShootAtTarget(Duelist target)
        {
            Random num = new Random();
            double shot = num.NextDouble();
            if(shot <= ShootingAcc)
            {
                target.Alive = false;
            }
            
        }
    }
}
