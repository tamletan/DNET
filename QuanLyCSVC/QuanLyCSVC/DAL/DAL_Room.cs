using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QuanLyCSVC
{
    public class DAL_Room
    {
        public DBHelper Helper { get; set; }
        public DAL_Room(string s)
        {
            Helper = new DBHelper(s);
        }
        public List<Room> GetRoomList(string s)
        {

            string Query = "Select * from RoomTab" + s;
            List<Room> Temp = new List<Room>();
            DataTable Temp1 = Helper.GetTable(Query);
            foreach (DataRow i in Temp1.Rows)
            {
                Temp.Add(GetRoom(i));
            }
            return Temp;
        }
        public DataTable GetDataTable()
        {
            string Query = "Select * from RoomClassTab";
            return Helper.GetTable(Query);
        }
        public void DALDelete(int RoomID)
        {
            string Query = "Delete from RoomTab where RoomID = "+ RoomID ;
            Helper.DBExecute(Query);
        }
        public Room GetRoom(DataRow DR)
        {
            Room Temp = new Room();
            Temp.RoomID = Convert.ToInt32(DR["RoomID"].ToString());
            Temp.RoomName = DR["RoomName"].ToString();
            Temp.RoomLevel = Convert.ToInt32(DR["RoomClass"].ToString());
            Temp.Stage = Convert.ToInt32(DR["Stage"].ToString());
            Temp.Capacity = Convert.ToInt32(DR["Capacity"].ToString());
            Temp.dayUse = Convert.ToDateTime(DR["DayUse"].ToString());
            if (Convert.ToBoolean(DR["Stat"])) Temp.Stat = true;
            else Temp.Stat = false;
            return Temp;
        }
        public void DALADD(Room A)
        {
            string Query = "Insert into RoomTab values(@Name,@Stage,@Cap,@Stat,@dayUse,@Level)";
            Helper.DBExecuteWithValue(Query, A);
        }
        public Room GetRoom(int id)
        {
            Room temp = new Room();
            string Query = "Select * from RoomTab where RoomID = " + id;
            temp = this.GetRoom(Helper.GetTable(Query).Rows[0]);
            return temp;
        }
        public void Update(Room A)
        {
            string Query = "Update RoomTab Set RoomName = @Name,Stage = @Stage,Capacity = @Cap,Stat = @Stat,dayUse = @dayUse,RoomClass = @Level" +
                            " where RoomID =" + A.RoomID;
            Helper.DBExecuteWithValue(Query, A);
        }   
    }
}
