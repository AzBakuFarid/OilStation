using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using YDM.Model;

namespace YDM.Methods
{
    public static class Methods
    {
        public static object lockObj = new object();

        public static int getRandom(int a, int b)
        {
            Random r = new Random();
            var ab = r.Next(a, b);
            return ab;
        }
        public static int getRandom(int a)
        {
            Random r = new Random();
            var ba = r.Next(a);
            return ba;
        }
        public static Auto getNewAuto(int a, int b)
        {
            Auto auto = null;
            switch (getRandom(a, b))
            {
                case 1:
                    {
                        auto = new Car();
                    }; break;
                case 2:
                    {
                        auto = new Van();
                    }; break;
                case 3:
                    {
                        auto = new HGV();
                    }; break;
                default: return null;
            }
            auto.create();
            return auto;
        }
        public static void showAutos(IEnumerable<Auto> autos, TextBox textarea)
        {
            textarea.Text = "";
            if (autos.Count() > 0)
            {
                foreach (var item in autos.Reverse())
                {
                    textarea.Text += item.ToString() + Environment.NewLine + Environment.NewLine;
                };
            }
        }


    }
}
