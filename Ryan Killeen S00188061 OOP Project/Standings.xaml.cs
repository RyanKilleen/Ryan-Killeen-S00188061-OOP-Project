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
using System.Windows.Shapes;

namespace Ryan_Killeen_S00188061_OOP_Project
{
    //Start of class
    public partial class Standings : Window
    {
        //Declaring the String Variables For the Standings Tab and setting the drivers names teams and points in the string Variables 
        string[] standings_2019 = new string[] {"Lewis Hamilton - Mercedes - 413", "Valtteri Bottas - Mercedes - 326", "Max VerStappen - Red Bull Racing - 300", "Charles Leclerc - Ferrai - 264", "Sebastain Vettel - Ferrai - 240", "Carlos Sainz - McLaren - 96", "Pierre Gasly - Toro Rosso - 95", "Alexander Albon - Red Bull Racing - 92", "Daniel Ricciardo - Renault - 54", "Sergio Perez - Racing Point - 52", "Lando Norris - McLaren - 49", "Kimi Raikkonen - Alfa Romeo - 43", "Danil Kvyat - Toro Rosso - 37", "Nico Hulkenberg - Renault - 37", "Lance Stroll - Racing Point - 21", "Kevin Magnussen - Haas - 20", "Antonio Giovinazzi - Alfa Romeo - 14", "Romain Grosjean - Haas - 8", "Robert Kubica - Williams - 1", "George Russel - Williams - 0" };
        string[] standings_2018 = new string[] {"Lewis Hamilton - Mercedes - 408", "Sebastain Vettel - Ferrai - 320", "Kimi Raikkeon - Ferrai - 251", "Max VerStappen -Red Bull Racing - 249", "Valtteri Bottas - Mercedes - 247", "Daniel Riccardo - Red Bull Racing - 170", "Nico Hulkenberg - Renault - 69", "Sergio Perez - Force India - 62", "Kevin Magussen - Haas - 56", "Carlos Sainz - Renault - 53", "Fernado Alonso - Mclaren - 50", "Esteban Ocon - Force India - 49", "Charles Leclerc - Sauber - 39", "Romain Grosjean - Haas - 37", "Pierre Gasly - Toro Rosso - 29", "Stoffel VanDoorne - Mclaren - 12", "Marcus Ericisson - Sauber - 9", "Lance Stroll - Williams - 6", "Brendon Hartley - Toro Rosso - 4", "Sergey Sirotkin - Williams - 1" };
        string[] standings_2017 = new string[] {"Lewis Hamilton - Mercedes - 363", "Sebastian Vettel - Ferrai - 317", "Valtteri Bottas - Mercedes - 300", "Kimi Raikkeon - Ferrai - 205", "Daniel Riccardo - Red Bull Racing - 200", "Max Verstappen - Red Bull Racing  - 168", "Sergio Perez - Force India - 100", "Esteban Ocon -Force India - 87", "Carlos Sainz - Renault - 54", "Nico Hulkenburg - Renault - 43", "Felipe Massa - Williams - 43", "Lance Stroll - Williams - 40", "Romain Grosjean - Haas - 28", "Kevin Magnusseen - Haas - 19", "Fernando Alosno - Mclaren - 17", "Stoffel Vandoorne - Mclaren -13", "Jolyon Palmer - Renault - 8", "Pascal Wehrlein - Sauber - 5", "Danil Kvyat -Toro Rosso - 5", "Marcus Ericsson - Sauber - 0", "Pierre Gasly - Toro Rosso - 0", "Antonio Giovinazzi - Sauber - 0", "Brendon Hartley -Toro Rosso - 0" };

        //Declaring the list
        List<Driver> driversScores = new List<Driver>();
        

        public Standings()
        {
            InitializeComponent();
            //This is to link the declared strings into the combo box on the xaml page 
            cbxnames.ItemsSource = new string[] {"2019","2018","2017" };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Creating the The Driver List to add to the data template formating 
            Driver d1 = new Driver { DriverName = "Lewis Hamilton", DriverNumber = "44", Points = 413 , DriverImage = "DriverImages/Lewis.png" };
            Driver d2 = new Driver { DriverName = "Valtteri Bottas", DriverNumber = "77", Points = 326 , DriverImage = "DriverImages/Valtteri.png" };
            Driver d3 = new Driver { DriverName = "Max VerStappen", DriverNumber = "33", Points = 300, DriverImage = "DriverImages/Max.png" };
            Driver d4 = new Driver { DriverName = "Charles Leclerc", DriverNumber = "16", Points = 264, DriverImage = "DriverImages/Charles Leclerc.png" };
            Driver d5 = new Driver { DriverName = "Sebastian Vettel", DriverNumber = "5", Points = 240, DriverImage = "DriverImages/Sebastian Vettel.png" };
            //Adding the Drivers to the List
            driversScores.Add(d1);
            driversScores.Add(d2);
            driversScores.Add(d3);
            driversScores.Add(d4);
            driversScores.Add(d5);
            //Setting The Listbox with the source items
            lbxDrivers.ItemsSource = driversScores;
        }

        //This private method is for the handle event Slection Changed 
        private void Cbxnames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //This is to check what was selected
            string selectedYear = cbxnames.SelectedItem as string; //2019 2018 2017

            //This is to make sure it's not null
            if (selectedYear != null)
            {
                //These are to display the standings for a year that is Selected on the Combo Box
                if (selectedYear == "2019")
                {
                    lbxStandings.ItemsSource = standings_2019;
                    lbxDrivers.ItemsSource = driversScores;
                }
                else if (selectedYear == "2018")
                {
                    lbxStandings.ItemsSource = standings_2018;
                    lbxDrivers.ItemsSource = driversScores;
                }
                else if (selectedYear == "2017")
                {
                    lbxStandings.ItemsSource = standings_2017;
                    lbxDrivers.ItemsSource = driversScores;
                }
            }
        }
    }
}//End of Class
