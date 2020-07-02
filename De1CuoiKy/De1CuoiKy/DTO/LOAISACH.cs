using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace De1CuoiKy
{
    [Table("LOAISACH")]
    public class LOAISACH
    {
        [Key]
        public string Maloai { get; set; }

        public string TenLoai { get; set; }

        public string Vitri { get; set; }

        public virtual ICollection<SACH> SACHs { get; set; }

        public LOAISACH()
        {
            SACHs = new HashSet<SACH>();
        }
    }
}
