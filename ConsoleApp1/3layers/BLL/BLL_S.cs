using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3layers
{
    class BLL_S
    {
        public DAL_S das { get; set; }

        public BLL_S(string s)
        {
            das = new DAL_S(s);
        }
        public List<StudentDTO> GetListS_BLL()
        {
            return das.GetListS_DAL();
        }
    }
}
