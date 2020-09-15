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
