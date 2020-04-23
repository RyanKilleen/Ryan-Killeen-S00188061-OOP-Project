using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryan_Killeen_S00188061_OOP_Project
{
    public class DriverTest
    {
        public int Points { get; set; }

        public void Adding(int amount)
        {
            Points += amount;
        }


       public void PointsDeDucted(int amount)
        {
            Points -= amount;
        }

    }
}
