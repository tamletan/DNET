using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDB.Models.Entities
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Sname { get; set; }
        public DateTime Sbirth { get; set; }
        public bool Gender { get; set; }
        public double DTB { get; set; }

        [ForeignKey("Faculty")]
        public int FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
