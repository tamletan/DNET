using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Models
{
    [Table("DVDT")]
    public class DVDT
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TenDVDT { get; set; }

        [ForeignKey("CoSo")]
        public int MaCoSo { get; set; }
        public virtual CoSo CoSo { get; set; }

        public virtual ICollection<GV> GVs { get; set; }
        public DVDT()
        {
            GVs = new HashSet<GV>();
        }
    }
}
