using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace De1CuoiKy
{
    [Table("DOCGIA")]
    public class DOCGIA
    {
        [Key]
        public string Madg { get; set; }

        public string Hoten { get; set; }
        public bool Gioitinh { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string Coquan { get; set; }

        public virtual ICollection<MUONTRA> MUONTRAs { get; set; }
        public DOCGIA()
        {
            MUONTRAs = new HashSet<MUONTRA>();
        }
    }
}
