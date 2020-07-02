using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace De1CuoiKy
{
    [Table("NHANVIEN")]
    public class NHANVIEN
    {
        [Key]
        public string Manv { get; set; }

        public string Hoten { get; set; }
        public Boolean Gioitinh { get; set;}

        public virtual ICollection<MUONTRA> MUONTRAs { get; set; }
        public NHANVIEN()
        {
            MUONTRAs = new HashSet<MUONTRA>();
        }
    }
}