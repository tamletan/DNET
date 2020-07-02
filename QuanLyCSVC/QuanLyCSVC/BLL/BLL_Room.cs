using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCSVC
{
    public class BLL_Room
    {
        public DAL_Room DALRoom;
        List<Room> Data;
        public BLL_Room(string s)
        {
            DALRoom = new DAL_Room(s);
            Data = DALRoom.GetRoomList("");
        }
        public List<Room> BLLGetRoomList()
        {
            //List<Room> Temp = new List<Room>();
            //Temp = DALRoom.GetRoomList();
            return DALRoom.GetRoomList("");
        }
        public void BLLDelete(int RoomID)
        {
            DALRoom.DALDelete(RoomID);
        }
        public void BLLAdd(Room A)
        {
            DALRoom.DALADD(A);
        }
        public Room BLLGetRoom(int id)
        {
            return DALRoom.GetRoom(id);
        }
        public void Update(Room A)
        {
            DALRoom.Update(A);
        }
        public List<Room> StageSearch(int stage)
        {
            string s = " where Stage=" + stage;
            return DALRoom.GetRoomList(s);
        }
        public List<Room> ClassSearch(int Class)
        {
            string s = " where RoomClass=" + Class;
            return DALRoom.GetRoomList(s);
        }
        public DataTable GetRoomTable()
        {
            return DALRoom.GetDataTable();
        }
        /*public DataTable StringSearch(DataGridView A,string s)
        {
            DataTable temp = new DataTable();
            foreach(DataGridViewRow i in A.Rows)
            {
                if(i.Cells["RoomName"].ToString().Contains(s)|| i.Cells["RoomID"].ToString().Contains(s) || i.Cells["Capacity"].ToString().Contains(s))
                {
                    temp.add
                }
            }
        }*/
        public List<Room> Search(string key)
        {
            List<Room> search = new List<Room>();
            foreach(Room i in Data)
            {
                if(i.RoomID.ToString().Contains(key)||i.RoomName.Contains(key))
                {
                    search.Add(i);
                }
            }
            return search;
        }
    }
}
