using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    class Email : Document
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Title { get; set; }
        
        public new void toString()
        {
            Console.WriteLine("New Email Message: ");
            Console.WriteLine("Sender: " + Sender + " Recipient: " + Recipient);
            Console.WriteLine(Title);
            Console.WriteLine(Text);
        }
    }
}
