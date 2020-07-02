using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLISACH
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public string MaNV { get; set; }

        public string HoTenNV { get; set; }
        public bool GioiTinhNV { get; set; }

        public virtual ICollection<MuonTra> MuonTras { get; set; }
        public NhanVien()
        {
            MuonTras = new HashSet<MuonTra>();
        }

    }
}
