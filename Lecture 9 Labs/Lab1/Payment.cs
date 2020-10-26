using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Lab1
{
    class Payment
    {
        //Instance Variables
        private double _paymentAmount;

        //Constructors
        public Payment()
        {
            _paymentAmount = 0;
        }
        public Payment(double p)
        {
            _paymentAmount = p;
        }

        //Getters and Setters
        public double PaymentAmount { get; set; }

        //Methods
        public void PaymentDetais()
        {
            Console.WriteLine("The total payment is: $" + _paymentAmount);
        }
    }

    class CashPayment : Payment
    {
        //Instance Variables

        //Constructors
        public CashPayment()
        {
            PaymentAmount = 0;
        }
        public CashPayment(double p)
        {
            PaymentAmount = p;
        }
        //Getters and Setters

        //Methods
        public void PaymentDetails()
        {
            Console.WriteLine("Payment Type: Cash");
            Console.WriteLine("The total payment is: $" + PaymentAmount);
        }
    }

    class CreditCardPayment : Payment
    {
        //Instance Variables
        private string _cardName;
        private string _cardNumber;
        //Constructors
        public CreditCardPayment()
        {
            PaymentAmount = 0;
            CardName = "None";
            CardNumber = "0000000";
        }
        public CreditCardPayment(double p, string n, string num)
        {
            PaymentAmount = p;
            CardName = n;
            CardNumber = num;
        }
        //Getters and Setters
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        //Methods
        public void PaymentDetails()
        {
            Console.WriteLine("Payment Type: Credit Card");
            Console.WriteLine("Card Name: " + CardName);
            Console.WriteLine("Card Number: " + CardNumber);
            Console.WriteLine("The total payment is: $" + PaymentAmount);
        }

    }
}
