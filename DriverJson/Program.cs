using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace DriverJson
{
    //Start Of Class
    class Program
    {
        //Starting The json file to write
        static void Main(string[] args)
        {
            string data = JsonConvert.SerializeObject(GetRandomDriverAccounts(), Formatting.Indented);

            using (StreamWriter sw = new StreamWriter("c:/temp/accountdata.json"))
            {
                sw.Write(data);
                sw.Close();
            }

        }
        //Creating a driver list method with a random inside it to make random drivers 
        private static List<DriverAccount> GetRandomDriverAccounts()
        {
            Random rand = new Random();
            List<DriverAccount> driverAccounts = new List<DriverAccount>();
            
            //Declaring the drivers for the method
            string [] names = new string[] { "Max", "Lewis", "Charles", "Alex", "Sebastain", "Valtteri" };

            for (int i = 0; i < 20; i++)
            {
                //Declaring Driver Numbers and random method
                int driverNumber = rand.Next(1, 99);
                int randomenumber = rand.Next(5);
                string DriverName = names[randomenumber];
                DriverAccount acc = new DriverAccount()
                {
                    DriverNumber = driverNumber,
                    DriverName = DriverName
                };

                driverAccounts.Add(acc);
            }
            return driverAccounts;
        }
    }
}//End of Class
