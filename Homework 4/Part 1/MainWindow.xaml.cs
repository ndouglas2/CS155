/// Chapter No. 4		Exercise No. 1
/// File Name: Homework4Part1.cs
/// @author: Nate Douglas
/// Date:  September 28, 2020
///
/// Problem Statement: Create a GUI that takes input of a person's weight and height and outputs their BMI.
/// 
/// 
/// Overall Plan:
/// 1) Create input text boxes for both height and weight
/// 2) Grab these inputs and put them into the BMI equation
/// 3) Create if statement to determine what gets output to the screen based on BMI
/// 4) Change colour and output message based on BMI
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

namespace Homework_4
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

        private void calculatebttn_Click(object sender, RoutedEventArgs e)
        {
            int weight = 0;
            int height = 0;
            int bmi = 0;

            weight = Convert.ToInt32(weighttxtbox.Text);
            height = Convert.ToInt32(heighttxtbox.Text);

            bmi = (weight * 720) / (height * height);

            if (bmi >= 15 && bmi <= 26)
            {
                BMICanvas.Background = Brushes.Green;
                outputtxtbox.Text = bmi.ToString();
                healthytxtbox.Text = "Congrats! You have a healthy BMI!";
            }
            else if (bmi < 15)
            {
                BMICanvas.Background = Brushes.Blue;
                outputtxtbox.Text = bmi.ToString();
                healthytxtbox.Text = "It looks like you have a low BMI. You may want to consult your doctor about this.";
            }
            else
            {
                BMICanvas.Background = Brushes.Red;
                outputtxtbox.Text = bmi.ToString();
                healthytxtbox.Text = "It looks like you have a high BMI. You may want to consult your doctor about this.";
            }
        }
    }
}
