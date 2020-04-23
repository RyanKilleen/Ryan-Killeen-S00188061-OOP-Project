using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace DriverJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = JsonConvert.SerializeObject(GetRandomDriverAccounts(), Formatting.Indented);

            using (StreamWriter sw = new StreamWriter("c:/temp/accountdata.json"))
            {
                sw.Write(data);
                sw.Close();
            }

        }

        private static List<DriverAccount> GetRandomDriverAccounts()
        {
            Random rand = new Random();
            List<DriverAccount> driverAccounts = new List<DriverAccount>();

            string [] names = new string[] { "Max", "Lewis", "Charles", "Alex", "Sebastain", "Valtteri" };

            for (int i = 0; i < 20; i++)
            {
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
}
