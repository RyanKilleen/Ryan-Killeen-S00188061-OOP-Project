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

namespace Ryan_Killeen_S00188061_OOP_Project
{
    public partial class MainWindow : Window
    {
        //Start Of Class
        public MainWindow()
        {
            InitializeComponent();
        }

        //This Opens the window to drivers and teams
        private void BtnDriversAndTeam_Click(object sender, RoutedEventArgs e)
        {
            DriversAndTeams newWindow = new DriversAndTeams();

            newWindow.ShowDialog();
        }

        //This Opens the Window to the track window
        private void BtnTrackGuide_Click(object sender, RoutedEventArgs e)
        {
            Track newWindow = new Track();

            newWindow.ShowDialog();
        }
        
        //This Opens a Window to the Standings Winodow
        private void BtnStandings_Click(object sender, RoutedEventArgs e)
        {
            Standings newWindow = new Standings();

            newWindow.ShowDialog();
        }

        //This Opens a Window to the DataBase Window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DriverListSorting newWindow = new DriverListSorting();

            newWindow.ShowDialog();
        }
    }
}//End of Class
