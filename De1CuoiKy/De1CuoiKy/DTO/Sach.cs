using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace De1CuoiKy
{
    [Table("SACH")]
    public class SACH
    {
        [Key]
        public string Masach { get; set; }
        public string Tensach { get; set; }
        public int Sotrang { get; set; }
        public string Tacgia { get; set; }
        [ForeignKey("LOAISACH")]
        public string Maloai { get; set; }
        public string NXB { get; set; }
        public int Soluong { get; set; }

        public virtual LOAISACH LOAISACH { get; set; }
        public virtual ICollection<MUONTRA> MUONTRAs { get; set; }

        public SACH()
        {
            MUONTRAs = new HashSet<MUONTRA>();
        }
    }
}
