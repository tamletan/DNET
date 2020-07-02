using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLISACH
{
    [Table("DocGia")]
    public class DocGia
    {
        [Key]
        public string MaDG { get; set; }

        public string HoTenDG { get; set; }
        public bool GioiTinhDG { get; set; }
        public DateTime NgaySinhDG { get; set; }
        public string DiaChi { get; set; }
        public string CoQuan { get; set; }

        public virtual ICollection<MuonTra> MuonTras { get; set; }
        public DocGia()
        {
            MuonTras = new HashSet<MuonTra>();
        }
    }
}
