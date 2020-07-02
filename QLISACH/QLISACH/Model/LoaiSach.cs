using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLISACH
{
    [Table("LoaiSach")]
    public class LoaiSach
    {
        [Key]
        public string MaLoai { get; set; }

        public string TenLoai { get; set; }
        public string ViTri { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
        public LoaiSach()
        {
            Saches = new HashSet<Sach>();
        }

    }
}
