using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YDM.Model
{
    class Transaction
    {
        public Pump Pump { get; set; }
        public double Litres { get; set; }
        public Timer fuelingTimer { get; set; }
        public Timer stopServicing { get; set; }

        public Transaction(Pump p)
        {
            Pump = p;
            initTimers();
        }
        public void initTimers()
        {
            fuelingTimer = new Timer { Interval = 1000 };
            fuelingTimer.Tick += fuelingTimer_Tick;
            fuelingTimer.Enabled = true;
            fuelingTimer.Start();

            stopServicing = new Timer { Interval = 18000 };
            stopServicing.Tick += stopTimer;
            stopServicing.Enabled = true;
            stopServicing.Start();
        }
        private void stopTimer(object sender, EventArgs e)
        {
            if (fuelingTimer.Enabled)
            {
                this.fuelingTimer.Stop();
                //this.fuelingTimer.Dispose();
                Pump.label.Text = "Azad kassa :))";

                this.stopServicing.Stop();
                //this.stopServicing.Dispose();
            }
        }
        private void fuelingTimer_Tick(object sender, EventArgs e)
        {

            if (Pump.Auto.TankCurrAmount < Pump.Auto.TankCapacity)
            {
                Pump.Auto.TankCurrAmount += 1.5;
                Litres += 1.5;
                Pump.label.Text = Pump.Auto.ToString();
            }
            else
            {
                if (fuelingTimer.Enabled)
                {
                    this.fuelingTimer.Stop();
                    //this.fuelingTimer.Dispose();
                    this.stopServicing.Stop();
                    //this.stopServicing.Dispose();
                    Pump.label.Text = "Azad kassa :))";
                }
            }
        }
    }
}
