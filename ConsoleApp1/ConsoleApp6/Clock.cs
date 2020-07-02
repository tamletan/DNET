using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventDelegate
{
    class Clock
    {
        public delegate void SecondChangeHandler(object obj, TimeEventArgs t);
        public event SecondChangeHandler OnSC;
        public void Run()
        {
            while(true)
            {
                Thread.Sleep(1000);
                if(OnSC!= null) //delegate ko tham chieu toi ham nao nen ko thuc hien
                    OnSC(this, new TimeEventArgs());
                Console.WriteLine();
            }
        }
    }
}
