/// Chapter No. 3		Exercise No. 1
/// File Name: Lab3Part1.cs
/// @author: Nate Douglas
/// Date:  September 14, 2020
///
/// Problem Statement: Create a program that takes in a first and last name, and outputs that name in Pig Latin. 
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for their first and last name
/// 3) Store those names in two variables
/// 4) Extract the first letter of each name. 
/// 5) Move that letter to the end of the variable.  
/// 6) Add "Ay" to the end of each new name
/// 7) Print to the screen. 

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

namespace Lab_1__GUI_Lab_
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String firstName = fnTxtBox.Text;
            String lastName = lnTxtBox.Text;

            //processes first name
            String pigLatinFirstName = firstName.Substring(1, firstName.Length - 1) + firstName.Substring(0, 1).ToLower() + "ay";
            pigLatinFirstName = pigLatinFirstName.Substring(0, 1).ToUpper() + pigLatinFirstName.Substring(1, pigLatinFirstName.Length - 1);

            //processes last name
            String pigLatinLastName = lastName.Substring(1, lastName.Length - 1) + lastName.Substring(0, 1).ToLower() + "ay";
            pigLatinLastName = pigLatinLastName.Substring(0, 1).ToUpper() + pigLatinLastName.Substring(1, pigLatinLastName.Length - 1);

            MessageBox.Show("Your name in Pig Latin is: " + pigLatinFirstName + " " + pigLatinLastName);
        }

        private void lnTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
