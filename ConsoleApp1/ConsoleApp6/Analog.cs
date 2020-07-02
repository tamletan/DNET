using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    class Analog
    {
        public void ShowAC(object obj, TimeEventArgs t)
        {
            Console.WriteLine("{0} / {1} / {2}   {3} : {4} : {5}.{6}", t.t.Day, t.t.Month, t.t.Year, t.t.Hour, t.t.Minute, t.t.Second,t.t.Millisecond);
        }
        public void Reg(Clock c)
        {
            c.OnSC += new Clock.SecondChangeHandler(ShowAC);
        }
    }
}
