using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVC_3Layers
{
    class DAL_R
    {
        DBHelp helpR { get; set; }

        public DAL_R(string s)
        {
            helpR = new DBHelp();
            helpR.data.ConnectionString = s;
        }

        public DataTable GetR()
        {
            string query = "select * from dbo.Room";
            return helpR.GetTable(query);
        }

        //public string GetLoaiP(int i)
        //{
        //    string query = "select * from dbo.Room where MaLoaiPhong = " + i.ToString();
        //    DataTable dt = helpR.GetTable(query);
        //    string s = dt.Rows[0]["LoaiPhong"].ToString();
        //    return s;
        //}

        //public int GetLoaiP(string i)
        //{
        //    string query = "select * from dbo.Room where LoaiPhong = '" + i +"'";
        //    DataTable dt = helpR.GetTable(query);
        //    int s = Convert.ToInt32(dt.Rows[0]["MaLoaiPhong"]);
        //    return s;
        //}
    }
}
