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

namespace Among_Us_Randomizer
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

        private void Accusebttn_Click(object sender, RoutedEventArgs e)
        {
            Colortxtbox1.Text = String.Empty;
            Colortxtbox2.Text = String.Empty;
            Roomtxtbox.Text = String.Empty;
            Actiontxtbox.Text = String.Empty;

            int rndmColor = 0;
            int rndmAction = 0;
            int rndmRoom = 0;

            string[] color = { "Red", "Blue", "Green", "Pink", "Orange", "Yellow", "Black", "White", "Purple", "Brown", "Cyan", "Lime", "You", "Me" };

            string[] room = { "Reactor", "Upper Engine", "Lower Engine", "Security", "MedBay", "Electrical", "Cafeteria", "Storage", "Admin", "Oxygen", "Weapons", "Nav.", "Shields", "Comms", "The Hallway"};

            string[] action = { "Kill", "Vent", "Fake Tasks", "Act Sus", "Sabotage", };

            Random generator = new Random();
            rndmColor = generator.Next(0, color.Length);
            rndmAction = generator.Next(0, action.Length);
            rndmRoom = generator.Next(0, room.Length);

            Colortxtbox1.AppendText(color[rndmColor]);
            Colortxtbox2.AppendText(color[rndmColor]);
            Roomtxtbox.AppendText(room[rndmRoom]);
            Actiontxtbox.AppendText(action[rndmAction]);

        }
    }
}
