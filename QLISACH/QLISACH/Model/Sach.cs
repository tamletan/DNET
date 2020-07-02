using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLISACH
{
    [Table("Sach")]
    public class Sach
    {  
        [Key]
        public string MaSach { get; set; }

        public string TenSach { get; set; }
        public int SoTrang { get; set; }
        public string TacGia { get; set; }

        [ForeignKey("LoaiSach")]
        public string MaLoai { get; set; }
       
        public string NXB { get; set; }
        public int SoLuong { get; set; }

        public virtual LoaiSach LoaiSach { get; set; }
        public virtual ICollection<MuonTra> MuonTras { get; set; }

        public Sach()
        {
            MuonTras = new HashSet<MuonTra>();
        }
    }
}
