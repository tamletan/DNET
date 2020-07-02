using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityCodeFirst.Model
{
    [Table("Faculty")]
    public class Faculty
    {
        public Faculty()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        public int Id { get; set; }

        public string Fname { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
