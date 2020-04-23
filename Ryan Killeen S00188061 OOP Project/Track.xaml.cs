using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// <summary>
    /// Interaction logic for Track.xaml
    /// </summary>
    public partial class Track : Window
    {
        //Start Of Class
        public Track()
        {
            InitializeComponent();
        }

        
        //This Button Is to pull one of the random Tracks
        private void BtnRandomTrack_Click(object sender, RoutedEventArgs e)
        {
            //Declaring all the data for the tracks
            TrackName t1 = new TrackName() { Name = "Austrailian Grand Prix", Location = "Austrialia", LastYearsWinners = new string[] { "Bottas", "Hamilton", "VerStappen" } };

            TrackName t2 = new TrackName() { Name = "Bahrain Grand Prix", Location = "Bahrain", LastYearsWinners = new string[] { "Hamilton", "Bottas", "Leclerc" } };

            TrackName t3 = new TrackName() { Name = "Chinese Grand prix", Location = "China", LastYearsWinners = new string[] { "Hamilton", "Bottas", "Vettel" } };

            TrackName t4 = new TrackName() { Name = "AzerBaijan Grand Prix", Location = "Baku", LastYearsWinners = new string[] { "Bottas", "Hamilton", "Vettel" } };

            TrackName t5 = new TrackName() { Name = "Spanish Grand Prix", Location = "Barcelona", LastYearsWinners = new string[] { "Hamilton", "Bottas", "VerStappen" } };

            TrackName t6 = new TrackName() { Name = "Monaco Grand Prix", Location = "Monaco", LastYearsWinners = new string[] { "Hamilton", "Vettel", "Bottas" } };

            TrackName t7 = new TrackName() { Name = "Canadian Grand Prix", Location = "Canada", LastYearsWinners = new string[] { "Hamilton", "Vettel", "Leclerc" } };

            TrackName t8 = new TrackName() { Name = "French Grand Prix", Location = "France", LastYearsWinners = new string[] { "Hamilton", "Bottas", "Leclerc" } };

            TrackName t9 = new TrackName() { Name = "Austrian Grand Prix", Location = "Austria", LastYearsWinners = new string[] { "VerStappen", "Leclerc", "Bottas" } };

            TrackName t10 = new TrackName() { Name = "British Grand Prix", Location = "SilverStone UK", LastYearsWinners = new string[] { "Hamilton", "Bottas", "Leclerc" } };

            TrackName t11 = new TrackName() { Name = "German Grand Prix", Location = "Germany", LastYearsWinners = new string[] { "VerStappen", "Vettel", "Kvyat" } };

            TrackName t12 = new TrackName() { Name = "Hungarian Grand Prix", Location = "Hungary", LastYearsWinners = new string[] { "Hamilton", "VerStappen", "Vettel" } };

            TrackName t13 = new TrackName() { Name = "Belgian Grand Prix", Location = "Belguim", LastYearsWinners = new string[] { "Leclerc", "Hamilton", "Bottas" } };

            TrackName t14 = new TrackName() { Name = "Italian Grand Prix", Location = "Monza", LastYearsWinners = new string[] { "Leclerc", "Bottas", "Hamilton" } };

            TrackName t15 = new TrackName() { Name = "Singapore Grand Prix", Location = "Singapore", LastYearsWinners = new string[] { "Vettel", "Leclerc", "VerStappen" } };

            TrackName t16 = new TrackName() { Name = "Russian Grand Prix", Location = "Russia", LastYearsWinners = new string[] { "Hamilton", "Bottas", "Leclerc" } };

            TrackName t17 = new TrackName() { Name = "Japense Grand Prix", Location = "Japan", LastYearsWinners = new string[] { "Bottas", "Vettel", "Hamilton" } };

            TrackName t18 = new TrackName() { Name = "Mexican Grand Prix", Location = "Mexico", LastYearsWinners = new string[] { "Hamilton", "Vettel", "Bottas" } };

            TrackName t19 = new TrackName() { Name = "USA Grand Prix", Location = "United States", LastYearsWinners = new string[] { "Bottas", "Hamilton", "VerStappen" } };

            TrackName t20 = new TrackName() { Name = "Brazilain Grand Prix", Location = "Brazil", LastYearsWinners = new string[] { "VerStappen", "Gasly", "Sainz" } };

            TrackName t21 = new TrackName() { Name = "Abu Dhabi Grand Prix", Location = "Abu dabhi", LastYearsWinners = new string[] { "Hamilton", "VerStappen", "Leclerc" } };

            //Declaring the List For the Tracks
            List<TrackName> alltracks = new List<TrackName>();
            //Here I am Adding the the tracks to the list 
            alltracks.Add(t1);
            alltracks.Add(t2);
            alltracks.Add(t3);
            alltracks.Add(t4);
            alltracks.Add(t5);
            alltracks.Add(t6);
            alltracks.Add(t7);
            alltracks.Add(t8);
            alltracks.Add(t9);
            alltracks.Add(t10);
            alltracks.Add(t11);
            alltracks.Add(t12);
            alltracks.Add(t13);
            alltracks.Add(t14);
            alltracks.Add(t15);
            alltracks.Add(t16);
            alltracks.Add(t17);
            alltracks.Add(t18);
            alltracks.Add(t19);
            alltracks.Add(t20);
            alltracks.Add(t21);
            //This is the method to make the tracks random
            Random r = new Random();
            int tracknumber = r.Next(0, 21);
            TrackName randomTrackname = alltracks[tracknumber];
            
            //This displays track information
            tblkTrackName.Text = randomTrackname.Name;
            tblkWinnersName.Text = randomTrackname.GetWinners();

        }
    }

    //This Method is holding the data for the tracks
    public class TrackName
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public string[] LastYearsWinners { get; set; }

        //This is the Method to add winners to the tracks random 
        public string  GetWinners()
        {
            string winners = "";

            foreach (var item in LastYearsWinners)
            {
                winners += item + "\n";
            }

            return winners;
        }
    }
}//End of Class
