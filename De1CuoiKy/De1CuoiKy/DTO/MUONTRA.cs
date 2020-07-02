using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace De1CuoiKy
{
    [Table("MUONTRA")]
    public class MUONTRA
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("NHANVIEN")]
        public string Manv { get; set; }
        [ForeignKey("DOCGIA")]
        public string Madg { get; set;}
        [ForeignKey("SACH")]
        public string Masach { get; set;}

        public DateTime Ngaymuon { get; set; }
        public DateTime Ngaytra { get; set; }
        public DateTime Ngayhentra { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual DOCGIA DOCGIA { get; set; }
        public virtual SACH SACH { get; set; }
    }
}
