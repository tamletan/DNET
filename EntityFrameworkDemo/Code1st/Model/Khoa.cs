using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Code1st
{
    [Table("Khoa")]
    public class Khoa
    {
        public Khoa()
        {
            SinhViens = new HashSet<SinhVien>();
        }
        [Key]
        public int ID { get; set; }

        public string TenKhoa { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
