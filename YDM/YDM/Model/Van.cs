using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDM.Model
{
    public class Van : Auto
    {
        public static int counter;
        public Van()
        {
            counter++;
            this.TankCapacity = 80;
            this.Name = "Van_" + counter;
            this.FuelTypes = new[] { Fuel.Diesel, Fuel.LPG };
           // create();

        }
    }
}
