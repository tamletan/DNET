using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectDB
{
    class DBHelp
    {
        public SqlConnection data { get; set; }
        public DBHelp()
        {
            data = new SqlConnection();
        }
        public void ExcuteDB(SqlCommand cmd)
        {
            //SqlCommand cmd = new SqlCommand(query,this.data);
            data.Open();
            cmd.ExecuteNonQuery();
            data.Close();
        }
        public void ExcuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query,this.data);
            data.Open();
            cmd.ExecuteNonQuery();
            data.Close();
        }
        public DataTable GetTable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, this.data); //mac dinh dua vao selectcommand
            DataTable dt = new DataTable();
            data.Open();
            da.Fill(dt);
            data.Close();
            return dt;
        }
    }
}
