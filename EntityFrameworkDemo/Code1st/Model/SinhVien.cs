using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code1st
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public int ID { get; set; }
        public string TenSV { get; set; }
        public bool Gioitinh { get; set; }
        public double Diem { get; set; }
        public DateTime Ngaysinh { get; set; }
        [ForeignKey("Khoa")]
        public int FID { get; set; }

        public virtual Khoa Khoa { get; set; }

    }
}
