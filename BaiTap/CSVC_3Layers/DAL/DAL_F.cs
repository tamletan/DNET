using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVC_3Layers
{
    class DAL_F
    {
        public DBHelp helpF { get; set; }

        public DAL_F(string s)
        {
            helpF = new DBHelp();
            helpF.data.ConnectionString = s;
        }

        public CSVC_DTO GetF_DAL(DataRow d)
        {
            CSVC_DTO s = new CSVC_DTO();
            s.MaPhong = Convert.ToInt32(d["MaPhong"]);
            s.TenPhong = d["TenPhong"].ToString();
            s.Tang = Convert.ToInt32(d["Tang"]);
            s.MaLoaiPhong = Convert.ToInt32(d["MaLoaiPhong"]);
            s.TrangThai = Convert.ToBoolean(d["TrangThai"]);
            s.NgaySuDung = Convert.ToDateTime(d["NgaySuDung"]);
            return s;
        }

        public CSVC_DTO GetF_DAL(int id)
        {
            CSVC_DTO s = new CSVC_DTO();
            string query = "select * from dbo.CSVC where MaPhong = "+id.ToString();
            DataTable dt = helpF.GetTable(query);
            s = GetF_DAL(dt.Rows[0]);
            return s;
        }

        public DataTable GetListF_DAL()
        {
            string query = "select * from dbo.CSVC ";
            return helpF.GetTable(query);            
        }

        public void AddF_DAL(CSVC_DTO i)
        {
            string query = "insert into dbo.CSVC values (@tenp,@tang,@malp,@tthai,@nsd)";
            SqlCommand cmd = new SqlCommand(query, helpF.data);
            
            cmd.Parameters.AddWithValue("@tenp", i.TenPhong);
            cmd.Parameters.AddWithValue("@tang", i.Tang);
            cmd.Parameters.AddWithValue("@malp", i.MaLoaiPhong);
            cmd.Parameters.AddWithValue("@tthai", i.TrangThai);
            cmd.Parameters.AddWithValue("@nsd", i.NgaySuDung);

            helpF.ExcuteDB(cmd);
        }

        public void UpdateF_DAL(CSVC_DTO i)
        {
            string query = "update dbo.CSVC set TenPhong=@tenp,Tang=@tang,MaLoaiPhong=@malp,TrangThai=@tthai,NgaySuDung=@nsd where MaPhong=@map";
            SqlCommand cmd = new SqlCommand(query, helpF.data);

            cmd.Parameters.AddWithValue("@map", i.MaPhong);
            cmd.Parameters.AddWithValue("@tenp", i.TenPhong);
            cmd.Parameters.AddWithValue("@tang", i.Tang);
            cmd.Parameters.AddWithValue("@malp", i.MaLoaiPhong);
            cmd.Parameters.AddWithValue("@tthai", i.TrangThai);
            cmd.Parameters.AddWithValue("@nsd", i.NgaySuDung);

            helpF.ExcuteDB(cmd);
        }

        public void DeleteF_DAL(int id)
        {
            string query = "delete from dbo.CSVC where MaPhong="+id.ToString();

            helpF.ExcuteDB(query);
        }

        public DataTable SortF_DAL(string header)
        {
            string query = "select * from dbo.CSVC order by " + header;
            return helpF.GetTable(query);
        }
    }
}
