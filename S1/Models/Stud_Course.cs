using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1.Models
{
    [Table("Stud_Course")]
    internal class Stud_Course
    {
        [Key]
        [Column("Stud_Id")]
        public int Stud_Id { get; set; }
        [Column("Course_Id")]
        public int Course_Id { get; set; }
        [Column("Grade")]
        public int Grade { get; set; }
    }
}
