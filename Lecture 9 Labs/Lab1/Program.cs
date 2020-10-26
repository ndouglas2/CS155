using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cash Payments
            Console.WriteLine("Cash Payment 1 using blank constructor and Properties to set the Payment Amount:");
            CashPayment payment1 = new CashPayment();
            payment1.PaymentAmount = 999;
            payment1.PaymentDetails();
            Console.WriteLine("");

            Console.WriteLine("Cash Payment 2 using Value pass through constructor to set values:");
            CashPayment payment2 = new CashPayment(300);
            payment2.PaymentDetails();
            Console.WriteLine("");

            //Credit Payments
            Console.WriteLine("Credit Card Payment 1 using blank constructor and Properties to set values:");
            CreditCardPayment credit1 = new CreditCardPayment();
            credit1.PaymentAmount = 670;
            credit1.CardName = "Jonathan Sims";
            credit1.CardNumber = "8894561";
            credit1.PaymentDetails();
            Console.WriteLine("");

            Console.WriteLine("Credit Card Payment 2 using Value pass through constructor to set values:");
            CreditCardPayment credit2 = new CreditCardPayment(450, "Quincey Jones", "1236547");
            credit2.PaymentDetails();
            Console.ReadLine();
        }
    }
}
