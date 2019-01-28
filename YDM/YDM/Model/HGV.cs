using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDM.Model
{
    public class HGV : Auto
    {
        public static int counter;
        public HGV()
        {
            counter++;
            this.TankCapacity = 150;
            this.Name = "HGV_" + counter;
            this.Fuel = Fuel.Diesel;
            this.FuelTypes = new[] { Fuel.Diesel };
           // create();

        }

    }
}
