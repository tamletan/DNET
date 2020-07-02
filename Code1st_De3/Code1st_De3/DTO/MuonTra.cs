using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code1st_De2
{
    [Table("MuonTra")]
    public class MuonTra
    {
        [Key]
        public int ID { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public DateTime NgayHenTra { get; set; }
        [ForeignKey("DocGia")]
        public int IDDG { get; set; }
        
        [ForeignKey("NhanVien")]
        public int IDNV { get; set; }
        
        [ForeignKey("Sach")]
        public int IDS { get; set; }
       
        public virtual DocGia DocGia { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual Sach Sach { get; set; }

    }
}
