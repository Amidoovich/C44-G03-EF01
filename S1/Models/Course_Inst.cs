using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1.Models
{
    [Table("Course_Inst")]
    internal class Course_Inst
    {
        [Key]
        [Column("Inst_Id")]
        public int Inst_ID { get; set; }
        [Column("Course_Id")]
        public int Course_Id { get; set; }
        [Column("Evaluate")]
        public int Evaluate {  get; set; }
    }
}
