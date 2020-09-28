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

namespace GUI_Lab
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

        private void Calculatebttn_Click(object sender, RoutedEventArgs e)
        {
            int speedLimit = 0;
            int userSpeed = 0;
            int ticketCost = 0;

            speedLimit = Convert.ToInt32(SLtxtbox.Text);
            userSpeed = Convert.ToInt32(InputSpeedtxtbox.Text);

            

            if (userSpeed <= speedLimit)
            {
                tempCanvas.Background = Brushes.Green;
                Penaltytxtbox.Text = "Congrats! You were going the speed limit.";
            }
            else if (userSpeed >= (speedLimit + 25))
            {
                tempCanvas.Background = Brushes.Red;
                ticketCost = 60 + (7 * (userSpeed - speedLimit)) + 250;
                Penaltytxtbox.Text = "Wow you were going fast! Sorry, but that is a $" + ticketCost + " ticket.";
            }
            else
            {
                tempCanvas.Background = Brushes.Yellow;
                ticketCost = 60 + (7 * (userSpeed - speedLimit));
                Penaltytxtbox.Text = "Well I guess you were going fast but it could have been worse. You will be issued a ticket of $" + ticketCost;
            }

        }
    }
}
