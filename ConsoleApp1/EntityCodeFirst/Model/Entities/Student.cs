using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityCodeFirst.Model
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Sname { get; set; }
        public DateTime Sbirth { get; set; }
        public bool Gender { get; set; }
        public double DTB { get; set; }

        [ForeignKey("Faculty")]
        public int FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
