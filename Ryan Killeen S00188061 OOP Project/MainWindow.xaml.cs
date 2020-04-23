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
        public MainWindow()
        {
            InitializeComponent();
        }

        //Open new window
        private void BtnDriversAndTeam_Click(object sender, RoutedEventArgs e)
        {
            DriversAndTeams newWindow = new DriversAndTeams();

            newWindow.ShowDialog();
        }

        private void BtnTrackGuide_Click(object sender, RoutedEventArgs e)
        {
            Track newWindow = new Track();

            newWindow.ShowDialog();
        }

        private void BtnStandings_Click(object sender, RoutedEventArgs e)
        {
            Standings newWindow = new Standings();

            newWindow.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DriverListSorting newWindow = new DriverListSorting();

            newWindow.ShowDialog();
        }
    }
}
