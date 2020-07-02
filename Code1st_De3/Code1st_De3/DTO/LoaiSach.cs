using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code1st_De2
{
    [Table("LoaiSach")]
    public class LoaiSach
    {
        [Key]
        public int ID { get; set; }
        public string TenLoai { get; set; }
        public string ViTri { get; set; }

        public virtual ICollection<Sach> Sachs { get; set; }
        public LoaiSach()
        {
            Sachs = new HashSet<Sach>();
        }
    }
}
