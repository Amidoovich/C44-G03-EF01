using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1.Models
{
    [Table("Instructors")]
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Name",TypeName ="Varchar")]
        [StringLength(50,MinimumLength =5,ErrorMessage = "Name Of Instructor Must be Less than 51 char and Name Of Instructor Must be More than 5 char")]
        public string Name { get; set; }
        [Column("Bouns")]
        public int Bouns { get; set; }
        [Column("Salary",TypeName = "decimal(8,2)")]
        public decimal Salary { get; set; }
        [Column("Address", TypeName = "Varchar")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Address Of Instructor Must be Less than 51 char and Address Of Instructor Must be More than 5 char")]
        public string Address { get; set; }
        [Column("HourRate")]
        public int HourRate { get; set; }
        [Column("Dept_Id")]
        public int Dept_Id { get; set; }

    }
}
