using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLISACH
{
    [Table("MuonTra")]
    public class MuonTra
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("NhanVien")]
        public string MaNV { get; set; }
        [ForeignKey("DocGia")]
        public string MaDG { get; set; }
        public string MaSach { get; set; }
        public DateTime NgayTra { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayHenTra { get; set; }

        public virtual Sach Sach { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual DocGia DocGia { get; set; }

    }
}
