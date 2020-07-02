using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCSVC
{
    public class DBHelper
    {
        public SqlConnection Connect { get; set; }
        public DBHelper(string s)
        {
            Connect = new SqlConnection(s);
        }
        public void DBExecute(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, this.Connect);
            this.Connect.Open();
            cmd.ExecuteNonQuery();
            this.Connect.Close();
        }
        public DataTable GetTable(string Query)
        {
            SqlDataAdapter SDA = new SqlDataAdapter(Query, this.Connect);
            DataTable DT = new DataTable();
            this.Connect.Open();
            SDA.Fill(DT);
            this.Connect.Close();
            return DT;
        }
        public void DBExecuteWithValue(string Query, Room A)
        {
            //string Query = "Insert into Room values (@Name,@Stage,@Cap,@Stat,@dayUse,@Level)";
            SqlCommand cmd = new SqlCommand(Query, this.Connect);
            //cmd.Parameters.AddWithValue("@RoomID",A.RoomID);
            cmd.Parameters.AddWithValue("@Name",A.RoomName);           
            cmd.Parameters.AddWithValue("@Stage",A.Stage);           
            cmd.Parameters.AddWithValue("@Cap",A.Capacity);
            cmd.Parameters.AddWithValue("@Stat", A.Stat);
            cmd.Parameters.AddWithValue("@dayUse",A.dayUse);
            cmd.Parameters.AddWithValue("@Level", A.RoomLevel);
            this.Connect.Open();
            cmd.ExecuteNonQuery();
            this.Connect.Close();
        }
       
    }
}
