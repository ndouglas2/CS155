/// Chapter No. 3		Exercise No. 1
/// File Name: Homework3Part1.cs
/// @author: Nate Douglas
/// Date:  September 20, 2020
///
/// Problem Statement: Write a program that takes in a loan principal and monthly payment, and calculates the interest and remaining balance.
/// 
/// 
/// Overall Plan:
/// 1) Have two text boxes displayed that ask for the principal and the payment being offered.
/// 2) Take those values and input them into an interest equation and a new balance equation
/// 3) Output all of this in a message box on the screen. 
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Part_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static double INTEREST_RATE = .0639;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Grabs entered loan balance from first text box
            double loanBalance = 0;
            loanBalance = Convert.ToInt32(LoanBalance.Text);

            //Uses entered loan balance to determine how much interest will be added to the payment
            double paymentInterest = (INTEREST_RATE / 12) * loanBalance;

            //Grabs entered monthly payment from the second text box. 
            double monthlyPayment = 0;
            monthlyPayment = Convert.ToInt32(PaymentAmount.Text);

            //Determines the remaining balance based on the entered balance, the payment and the interest
            double newBalance = loanBalance - (monthlyPayment - paymentInterest);

            //Outputs all of this to a message box on the screen
            MessageBox.Show("Your Current loan Balance is: $" + loanBalance + Environment.NewLine + "The current interest added this month is: $" + paymentInterest + 
                Environment.NewLine + "To confirm, you are paying: $" + monthlyPayment + " this month." + Environment.NewLine + "As such, your new loan balance is: $" + newBalance);
        }
    }
}
