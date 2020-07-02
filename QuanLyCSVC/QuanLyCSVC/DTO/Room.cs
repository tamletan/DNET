using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCSVC
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int RoomLevel { get; set; }
        public int Stage { get; set; }
        public int Capacity { get; set; }
        public bool Stat { get; set; }
        public DateTime dayUse { get; set; }
    }
}
