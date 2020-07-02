using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVC_3Layers
{
    class BLL_R
    {
        DAL_R dar { get; set; }

        public BLL_R(string s)
        {
            dar = new DAL_R(s);
        }

        public DataTable GetR()
        {
            return dar.GetR();
        }

        //public string GetLoaiP(int i)
        //{
        //    return dar.GetLoaiP(i);
        //}

        //public int GetLoaiP(string i)
        //{
        //    return dar.GetLoaiP(i);
        //}
    }
}
