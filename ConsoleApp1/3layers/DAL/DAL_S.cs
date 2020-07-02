using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3layers
{
    class DAL_S
    {
        public DBHelp helpS { get; set; }

        public DAL_S(string s)
        {
            helpS = new DBHelp();
            helpS.data.ConnectionString = s;
        }
        StudentDTO GetS_DAL(DataRow d)
        {
            StudentDTO s = new StudentDTO();
            s.MSSV = Convert.ToInt32(d["MSSV"]);
            s.Sname = d["Sname"].ToString();
            s.Sbirth = Convert.ToDateTime(d["Sbirth"]);
            s.FID = Convert.ToInt32(d["FID"]);
            s.DTB = Convert.ToDouble(d["DTB"]);
            s.Gender = Convert.ToBoolean(d["Gender"]);
            return s;
        }
        public List<StudentDTO> GetListS_DAL()
        {
            List<StudentDTO> ListS = new List<StudentDTO>();
            string query = "select * from dbo.Student";
            DataTable  dt = helpS.GetTable(query);
            foreach(DataRow i in dt.Rows)
            {
                ListS.Add(GetS_DAL(i));
            }
            return ListS;
        }
    }
}
