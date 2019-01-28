using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using YDM.Model;
using Timer = System.Windows.Forms.Timer;

namespace YDM
{
    public partial class Form1 : Form
    {

        public static Queue<Auto> autos;
        private Label[] stations;
        private int columnCounter;
        private List<Transaction> transactions;
        private List<Auto> unservicedAutos;
        private List<Pump> pumps;

        public Form1()
        {
            InitializeComponent();
            autos = new Queue<Auto>();
            pumps = new List<Pump>();
            transactions = new List<Transaction>();
            unservicedAutos = new List<Auto>();
            stations = new[] { label1, label2, label3, label4, label5, label6, label7, label8, label9 };
            foreach (var item in stations)
            {
                pumps.Add(new Pump { label = item });
            }
            columnCounter = 3;

            Start();

        }

        public void Start()
        {
            this.AddAuto_Timer.Enabled = true;
            this.AddAuto_Timer.Start();
            this.StartService_Timer.Enabled = true;
            this.StartService_Timer.Start();

        }

        private void AddAuto_Timer_Tick(object sender, EventArgs e)
        {
            Auto auto = null;
            this.AddAuto_Timer.Interval = Methods.Methods.getRandom(700, 1000);
            if (autos.Count < 5)
            {
                lock (Methods.Methods.lockObj)
                {
                    auto = Methods.Methods.getNewAuto(1, 4);
                    autos.Enqueue(auto);
                }
            }
            Methods.Methods.showAutos(autos, this.TextArea);
            Timer UnservecedsTimer = new Timer();
            UnservecedsTimer.Interval = 3000;
            UnservecedsTimer.Tick += (sender2, e2) =>
            {
                lock (Methods.Methods.lockObj)
                {
                    if (autos.Contains(auto))
                    {
                        unservicedAutos.Add(autos.Dequeue());
                    }
                }
            };
            UnservecedsTimer.Enabled = true;
            UnservecedsTimer.Start();
        }

        private bool isRoadToStationAcceptable(Label label)
        {
            if (label.Text != "Azad kassa :))") return false;
            if ((Array.IndexOf(stations, label)) % columnCounter == 0) return true;
            return isRoadToStationAcceptable(stations[Array.IndexOf(stations, label) - 1]);
        }


        private void StartService_Timer_Tick(object sender, EventArgs e)
        {
            Pump pump = null;
            var station = stations[Methods.Methods.getRandom(stations.Length)];
            lock (Methods.Methods.lockObj)
            {
                if (autos.Count > 0 && isRoadToStationAcceptable(station))
                {
                    var selectedAuto = autos.Dequeue();
                    pump = pumps.First(f => f.label.Equals(station));
                    pump.Auto = selectedAuto;
                    Methods.Methods.showAutos(autos, this.TextArea);
                    station.Text = selectedAuto.ToString();
                    transactions.Add(new Transaction(pump));
                }
            }

        }



        private void QuitBtn_Click(object sender, EventArgs e)
        {

            StartService_Timer.Stop();
            StartService_Timer.Dispose();
            AddAuto_Timer.Stop();
            AddAuto_Timer.Dispose();

            foreach (var item in transactions)
            {
                if (item.fuelingTimer.Enabled)
                {
                    item.fuelingTimer.Stop();
                    item.fuelingTimer.Dispose();

                }
            }

            var servicedCars = transactions.Where(w => w.Pump.Auto.GetType().ToString() == "YDM.Model.Car").ToList();
            var servicedHGVs = transactions.Where(w => w.Pump.Auto.GetType().ToString() == "YDM.Model.HGV").ToList();
            var servicedVans = transactions.Where(w => w.Pump.Auto.GetType().ToString() == "YDM.Model.Van").ToList();
            var UnservicedCars = unservicedAutos.Where(w => w.GetType().ToString() == "YDM.Model.Car").ToList();
            var UnservicedHGVs = unservicedAutos.Where(w => w.GetType().ToString() == "YDM.Model.HGV").ToList();
            var UnservicedVans = unservicedAutos.Where(w => w.GetType().ToString() == "YDM.Model.Van").ToList();

            string result = "           Car  |  Van  |  HGV  |  Totally" + Environment.NewLine;
            result += $"created :     {Car.counter}  |  {Van.counter}  |  {HGV.counter}  |  {Car.counter + Van.counter + HGV.counter}" + Environment.NewLine;
            result += $"serviced :    {servicedCars.Count}  |  {servicedVans.Count}  |  {servicedHGVs.Count}  |  {transactions.Count}" +  Environment.NewLine;
            result += $"unserviced :  {UnservicedCars.Count}  |  {UnservicedVans.Count}  |  {UnservicedHGVs.Count}  |  {unservicedAutos.Count}" +  Environment.NewLine;
            result += $"dispenced oils (in litres)" + Environment.NewLine;
            result += $"Diesel   -> {transactions.Where(w => w.Pump.Auto.Fuel == Fuel.Diesel).Sum(s => s.Litres)}" + Environment.NewLine +
                      $"Gasoline -> {transactions.Where(w => w.Pump.Auto.Fuel == Fuel.Gasoline).Sum(s => s.Litres)}" + Environment.NewLine +
                      $"LPG      -> {transactions.Where(w => w.Pump.Auto.Fuel == Fuel.LPG).Sum(s => s.Litres)}" + Environment.NewLine +
                      $"Totally  -> {transactions.Sum(s => s.Litres)}";

            MessageBox.Show(result);

            string autooo = "";
            foreach (var item in unservicedAutos)
            {
                autooo += item.ToString() + Environment.NewLine;
            }
            MessageBox.Show(autooo);

            string aut = "";
            foreach (var item in transactions)
            {
                aut += item.Pump.Auto.ToString() + Environment.NewLine;
            }
            MessageBox.Show(aut);
        }
    }
}
