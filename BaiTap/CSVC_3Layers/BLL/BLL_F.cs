using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVC_3Layers
{
    class BLL_F
    {
        public DAL_F daf { get; set; }
        public DataTable dt;

        public BLL_F(string s)
        {
            daf = new DAL_F(s);
            dt = new DataTable();
        }

        public DataTable GetListF_BLL()
        {
            dt = daf.GetListF_DAL();
            return dt;
        }

        public CSVC_DTO GetF_BLL(int id)
        {
            return daf.GetF_DAL(id);
        }

        public void AddF_BLL(CSVC_DTO i)
        {
            daf.AddF_DAL(i);
        }

        public void UpdateF_BLL(CSVC_DTO i)
        {
            daf.UpdateF_DAL(i);
        }

        public void DeleteF_BLL(List<int> id)
        {
            foreach(int i in id)
            {
                daf.DeleteF_DAL(i);
            }            
        }

        public DataTable SortF_BLL(string header , List<int> id)
        {
            dt.Clear();
            dt = daf.SortF_DAL(header);
            int n = dt.Rows.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                if (!id.Contains(Convert.ToInt32(dt.Rows[i]["MaPhong"])))
                    dt.Rows.Remove(dt.Rows[i]);
            }
            return dt;
        }

        public DataTable SelectCB_BLL(string header,string value)
        {
            int n = dt.Rows.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                if (dt.Rows[i][header].ToString() != value)
                    dt.Rows.Remove(dt.Rows[i]);
            }
            return dt;
        }

        public DataTable Search_BLL(string value)
        {
            int n = dt.Rows.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                if ((!dt.Rows[i]["MaPhong"].ToString().Contains(value)) && (!dt.Rows[i]["TenPhong"].ToString().Contains(value)) )
                    dt.Rows.Remove(dt.Rows[i]);
            }
            return dt;
        }
    }
}
