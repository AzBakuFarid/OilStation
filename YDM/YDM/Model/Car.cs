using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDM.Model
{
    public class Car : Auto
    {
        public static int counter;
        public Car()
        {
            counter++;
            this.TankCapacity = 40;
            this.Name = "Car_" + counter;
            this.FuelTypes = new[] { Fuel.Diesel, Fuel.Gasoline, Fuel.LPG };
            //create();

        }
    }
}
