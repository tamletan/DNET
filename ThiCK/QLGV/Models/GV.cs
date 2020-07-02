using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Models
{
    [Table("GV")]
    public class GV
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public int SDT { get; set; }
        public string GhiChu { get; set; }

        [ForeignKey("DVDT")]
        public int MaDVDT { get; set; }
        public virtual DVDT DVDT { get; set; }
    }
}
