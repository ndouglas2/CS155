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

namespace Lecture6Lab1
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
            /*
             * Value 0 = +
             * Value 1 = -
             * Value 2 = *
             * Value 3 = /
             * Value 4 = %
             */ 
            try
            {
                int operation = operandlist.SelectedIndex;
                decimal val1 = Convert.ToDecimal(val1txtbx.Text);
                decimal val2 = Convert.ToDecimal(val2txtbx.Text);
                decimal result = 0;

                switch (operation)
                {
                    case 0:
                        result = val1 + val2;
                        resultTxtbx.Text = result.ToString();
                        break;
                    case 1:
                        result = val1 - val2;
                        resultTxtbx.Text = result.ToString();
                        break;
                    case 2:
                        result = val1 * val2;
                        resultTxtbx.Text = result.ToString();
                        break;
                    case 3:
                        result = val1 / val2;
                        resultTxtbx.Text = result.ToString();
                        break;
                    case 4:
                        result = val1 % val2;
                        resultTxtbx.Text = result.ToString();
                        break;
                    default:
                        result = 0;
                        MessageBox.Show("No Operation was selected");
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error: Divide by 0 does not compute.");
            }
        }
    }
}
