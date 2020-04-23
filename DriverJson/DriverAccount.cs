using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverJson
{
    //Start Of Class
    class DriverAccount
    {
        //Declaring Variables For the json file
        public string DriverName { get; set; }
        public int DriverNumber { get; set; }

        //More Variables
        public DriverAccount(string driverName, int driverNumber)
        {
            DriverNumber = driverNumber;
            DriverNumber = driverNumber;
        }

        public DriverAccount(string driverNumber) : this(driverNumber, 0) { }

        public DriverAccount() : this("Unkown") { }

        public override string ToString()
        {
            return string.Format("[{0}] {1} {2:c}", this.GetType().Name.ToUpper(), DriverName, DriverNumber);
        }

    }
}//End of class
