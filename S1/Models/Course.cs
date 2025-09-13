using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Duration { get; set; }
        [Required]
        public string Name { get; set; }
        [Column("Description",TypeName ="varchar")]
        [StringLength(100,MinimumLength = 50,ErrorMessage ="The Discription Must be less than 101 and more than 51")]
        public string? Description { get; set; }
        public int Top_Id { get; set; }
    }
}
