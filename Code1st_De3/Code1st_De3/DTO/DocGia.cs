using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code1st_De2
{
    [Table("DocGia")]
    public class DocGia
    {
        [Key]
        public int ID { get; set; }

        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string CoQuan { get; set; }

        public virtual ICollection<MuonTra> MuonTras { get; set; }
        public DocGia()
        {
            MuonTras = new HashSet<MuonTra>();
        }
    }
}
