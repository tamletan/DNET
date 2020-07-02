using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code1st_De2
{
    [Table("Nhanvien")]
    public class NhanVien
    {
         [Key]
         public int ID { get; set; }
         public bool GioiTinh { get; set; }
         public string Ten { get; set; }

        public virtual ICollection<MuonTra> MuonTras { get; set; }
        public NhanVien()
        {
            MuonTras = new HashSet<MuonTra>();
        }
    }
}
