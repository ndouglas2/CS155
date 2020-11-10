using System;
using System.Collections.Generic;
using System.Text;

namespace Part_1
{
    class Person
    {
        public string Name { get; set; }

        //Constructors
        public Person()
        {

        }
        public Person(string n)
        {
            Name = n;
        }

        public void ToString()
        {
            Console.WriteLine("Owner: " + Name);
        }

        public bool Equals(Person obj)
        {
            return (this.Name == obj.Name);
        }
    }
}
