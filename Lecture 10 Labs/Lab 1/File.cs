using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    class File : Document
    {
        public string Path { get; set; }

        public new void toString()
        {
            Console.WriteLine("File path: " + Path);
            Console.WriteLine("Contents: " + Text);
        }
    }
}
