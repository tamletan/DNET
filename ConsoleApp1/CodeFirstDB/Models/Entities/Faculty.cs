using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models.Entities
{
    [Table("Faculty")]
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Fname { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public Faculty()
        {
            Students = new HashSet<Student>();
        }
    }
}
