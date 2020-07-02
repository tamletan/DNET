using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock();
            Analog a = new Analog();
            Digital d = new Digital();
            //a.Reg(c);
            //d.Reg(c);
            c.OnSC += new Clock.SecondChangeHandler(a.ShowAC);
            c.OnSC += new Clock.SecondChangeHandler(d.ShowDC);
            c.Run();
        }
    }
}
