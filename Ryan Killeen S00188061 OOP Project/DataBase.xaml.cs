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
    /// <summary>
    /// Interaction logic for DataBase.xaml
    /// </summary>
    public partial class DriverListSorting : Window
    {
        public DriverListSorting()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FomulaOneDataBaseEntities db = new FomulaOneDataBaseEntities();

            var query = from a in db.Drivers
                        select a.Name;

            lbxDrivers.ItemsSource = query.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FomulaOneDataBaseEntities db = new FomulaOneDataBaseEntities();

            var query = from a in db.Teams
                        select a.Team1;

            lbxTeams.ItemsSource = query.ToList();
        }
    }
}
