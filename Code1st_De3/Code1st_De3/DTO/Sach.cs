using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1st_De2
{
    [Table("Sach")]
    public class Sach
    {
        [Key]
        public int ID { get; set; }
        public string TenSach { get; set; }
        public int SoTrang { get; set; }
        public string TacGia { get; set; }
        [ForeignKey("LoaiSach")]
        public int IDS { get; set; }
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
