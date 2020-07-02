using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    class TimeEventArgs : EventArgs
    {
        public DateTime t = DateTime.Now;
    }
}
