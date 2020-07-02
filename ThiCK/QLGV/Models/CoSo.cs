using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Models
{
    [Table("CoSo")]
    public class CoSo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TenCoSo { get; set; }

        public virtual ICollection<DVDT> DVDTs { get; set; }
        public CoSo()
        {
            DVDTs = new HashSet<DVDT>();
        }
    }
}
