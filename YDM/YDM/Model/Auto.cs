using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YDM.Model;

namespace YDM
{
    public class Auto
    {
        public Auto()
        {
            
        }
        public int TankCapacity { get; set; }
        public double TankCurrAmount { get; set; }
        public string Name { get; set; }
        public Fuel[] FuelTypes { get; set; }
        public Fuel Fuel { get; set; }
        public virtual void create() {
            Fuel = FuelTypes[Methods.Methods.getRandom(0,FuelTypes.Length)];
            TankCurrAmount = Methods.Methods.getRandom(1, TankCapacity / 4);
        }
        public override string ToString()
        {
            return this.Name+", "+this.Fuel+", "+this.TankCurrAmount+" litres";
        }
    }
}
